using System.Runtime.CompilerServices;

namespace InliningEhProof;

/// <summary>
/// Все измеряемые методы. Внутри каждой четвёрки методы выполняют одну и ту же
/// работу, а разница между ними одна: в IL есть блок обработки исключений
/// или его нет. У одного метода счётчик увеличивается в finally, у другого
/// обычной строкой; обход списка написан через foreach и через MoveNext.
/// У вызываемых методов атрибута нет - по ним и проверяется, подставит JIT
/// их код в место вызова или нет. NoInlining стоит на вызывающих Call*,
/// их меряет BenchmarkDotNet и их машинный код снимает проект Disasm.
/// Методы Blocked повторяют тот же код с запретом на подстановку.
/// </summary>
public static class Subjects
{
    /// <summary>
    /// Обходов списка за одну операцию. При одном обходе разница выходит
    /// порядка наносекунды, и её не отделить от колонки Error.
    /// Отчёты, README и статья берут это число отсюда.
    /// </summary>
    public const int ListRounds = 64;

    private static int _touched;

    /// <summary>
    /// Счётчик обращений. Добавлен затем, чтобы finally не был пустым:
    /// пустой finally JIT удаляет на любом рантайме, и методы становятся
    /// одинаковыми. Запись идёт через Volatile.Write: иначе JIT вправе
    /// вынести увеличение счётчика за пределы цикла, и замер покажет
    /// разницу не между рантаймами, а между двумя объёмами работы.
    /// На x64 такая запись - обычный mov. Читается отчётом checks.
    /// </summary>
    public static int Touched => Volatile.Read(ref _touched);

    public static int[] CreateArray(int elements)
    {
        int[] data = new int[elements];
        for (int i = 0; i < elements; i++)
        {
            data[i] = i + 1;
        }

        return data;
    }

    public static List<int> CreateList(int elements)
    {
        List<int> data = new(elements);
        for (int i = 0; i < elements; i++)
        {
            data.Add(i + 1);
        }

        return data;
    }

    /// <summary>
    /// Ожидаемая сумма набора из elements элементов, заполненного числами
    /// от 1 до elements. Все двенадцать методов возвращают её.
    /// </summary>
    public static int ExpectedSum(int elements)
    {
        return elements * (elements + 1) / 2;
    }

    public static int ElementPlain(int[] data, int index)
    {
        int value = data[index];

        Volatile.Write(ref _touched, _touched + 1);
        return value;
    }

    public static int ElementFinally(int[] data, int index)
    {
        try
        {
            return data[index];
        }
        finally
        {
            Volatile.Write(ref _touched, _touched + 1);
        }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int ElementPlainBlocked(int[] data, int index)
    {
        int value = data[index];

        Volatile.Write(ref _touched, _touched + 1);
        return value;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int ElementFinallyBlocked(int[] data, int index)
    {
        try
        {
            return data[index];
        }
        finally
        {
            Volatile.Write(ref _touched, _touched + 1);
        }
    }

    /// <summary>
    /// Те же два метода, но без обращений к памяти: вместо счётчика стоит
    /// проверка, которая не срабатывает. Нужны для машин, где запись
    /// в общее статическое поле занимает больше времени, чем сам вызов,
    /// и перекрывает разницу. Блок обработки исключений в IL никуда
    /// не девается, а решение JIT принимает как раз по IL.
    /// </summary>
    public static int ElementGuardPlain(int[] data, int index)
    {
        int value = data[index];
        if (index < 0)
        {
            throw new InvalidOperationException("Отрицательный индекс");
        }

        return value;
    }

    public static int ElementGuardFinally(int[] data, int index)
    {
        try
        {
            return data[index];
        }
        finally
        {
            if (index < 0)
            {
                throw new InvalidOperationException("Отрицательный индекс");
            }
        }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int ElementGuardPlainBlocked(int[] data, int index)
    {
        int value = data[index];
        if (index < 0)
        {
            throw new InvalidOperationException("Отрицательный индекс");
        }

        return value;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int ElementGuardFinallyBlocked(int[] data, int index)
    {
        try
        {
            return data[index];
        }
        finally
        {
            if (index < 0)
            {
                throw new InvalidOperationException("Отрицательный индекс");
            }
        }
    }

    /// <summary>
    /// Обход списка через MoveNext: Dispose вызывается за пределами try,
    /// блока обработки исключений в IL нет.
    /// </summary>
    public static int ListManual(List<int> data)
    {
        List<int>.Enumerator enumerator = data.GetEnumerator();

        int sum = 0;
        while (enumerator.MoveNext())
        {
            sum += enumerator.Current;
        }

        enumerator.Dispose();

        Volatile.Write(ref _touched, _touched + 1);
        return sum;
    }

    /// <summary>
    /// Тот же обход через foreach. Компилятор превращает его в try/finally
    /// с вызовом Dispose у перечислителя, и блок обработки исключений
    /// появляется в IL, хотя в исходнике его никто не писал.
    /// </summary>
    public static int ListForeach(List<int> data)
    {
        int sum = 0;
        foreach (int value in data)
        {
            sum += value;
        }

        Volatile.Write(ref _touched, _touched + 1);
        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int ListManualBlocked(List<int> data)
    {
        List<int>.Enumerator enumerator = data.GetEnumerator();

        int sum = 0;
        while (enumerator.MoveNext())
        {
            sum += enumerator.Current;
        }

        enumerator.Dispose();

        Volatile.Write(ref _touched, _touched + 1);
        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int ListForeachBlocked(List<int> data)
    {
        int sum = 0;
        foreach (int value in data)
        {
            sum += value;
        }

        Volatile.Write(ref _touched, _touched + 1);
        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CallElementPlain(int[] data)
    {
        int sum = 0;
        for (int i = 0; i < data.Length; i++)
        {
            sum += ElementPlain(data, i);
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CallElementFinally(int[] data)
    {
        int sum = 0;
        for (int i = 0; i < data.Length; i++)
        {
            sum += ElementFinally(data, i);
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CallElementPlainBlocked(int[] data)
    {
        int sum = 0;
        for (int i = 0; i < data.Length; i++)
        {
            sum += ElementPlainBlocked(data, i);
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CallElementFinallyBlocked(int[] data)
    {
        int sum = 0;
        for (int i = 0; i < data.Length; i++)
        {
            sum += ElementFinallyBlocked(data, i);
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CallElementGuardPlain(int[] data)
    {
        int sum = 0;
        for (int i = 0; i < data.Length; i++)
        {
            sum += ElementGuardPlain(data, i);
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CallElementGuardFinally(int[] data)
    {
        int sum = 0;
        for (int i = 0; i < data.Length; i++)
        {
            sum += ElementGuardFinally(data, i);
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CallElementGuardPlainBlocked(int[] data)
    {
        int sum = 0;
        for (int i = 0; i < data.Length; i++)
        {
            sum += ElementGuardPlainBlocked(data, i);
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CallElementGuardFinallyBlocked(int[] data)
    {
        int sum = 0;
        for (int i = 0; i < data.Length; i++)
        {
            sum += ElementGuardFinallyBlocked(data, i);
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CallListManual(List<int> data)
    {
        int sum = 0;
        for (int i = 0; i < ListRounds; i++)
        {
            sum += ListManual(data);
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CallListForeach(List<int> data)
    {
        int sum = 0;
        for (int i = 0; i < ListRounds; i++)
        {
            sum += ListForeach(data);
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CallListManualBlocked(List<int> data)
    {
        int sum = 0;
        for (int i = 0; i < ListRounds; i++)
        {
            sum += ListManualBlocked(data);
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CallListForeachBlocked(List<int> data)
    {
        int sum = 0;
        for (int i = 0; i < ListRounds; i++)
        {
            sum += ListForeachBlocked(data);
        }

        return sum;
    }
}
