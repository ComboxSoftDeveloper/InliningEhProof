using System.Diagnostics;

namespace InliningEhProof.Diagnostics;

/// <summary>
/// Два отчёта вне BenchmarkDotNet.
/// checks - сверка ответов всех двенадцати методов с ожидаемой суммой,
/// останавливает прогон при расхождении.
/// timing - тот же замер на Stopwatch. Нужен, чтобы главный результат стоял
/// на двух независимых счётчиках. Каждый метод прогревается отдельно
/// на WarmupMilliseconds, иначе в замер попадёт код до Tier1.
/// Запуск: dotnet run -c Release -f net10.0 -- checks
///         dotnet run -c Release -f net10.0 -- timing
/// </summary>
public static class Diagnostic
{
    private const int BatchSize = 256;

    private const int WarmupMilliseconds = 2000;
    private const int MeasureMilliseconds = 3000;

    private static readonly int[] Sizes = [4, 16, 64];
    private static int _sink;

    public static bool PrintChecks()
    {
        Console.WriteLine($"Runtime: {Environment.Version}");
        Console.WriteLine($"Обходов списка за операцию: {Subjects.ListRounds}");

        Console.WriteLine();
        Console.WriteLine($"{"Метод",-26}{"Элементов",10}{"Ответ",14}{"Ожидалось",14}");

        bool passed = true;
        foreach (int elements in Sizes)
        {
            int[] array = Subjects.CreateArray(elements);
            List<int> list = Subjects.CreateList(elements);

            int elementExpected = Subjects.ExpectedSum(elements);
            int listExpected = elementExpected * Subjects.ListRounds;

            passed &= CheckRow("Element_Finally", elements, Subjects.CallElementFinally(array), elementExpected);
            passed &= CheckRow("Element_Plain", elements, Subjects.CallElementPlain(array), elementExpected);

            passed &= CheckRow("Element_FinallyBlocked", elements, Subjects.CallElementFinallyBlocked(array), elementExpected);
            passed &= CheckRow("Element_PlainBlocked", elements, Subjects.CallElementPlainBlocked(array), elementExpected);

            passed &= CheckRow("Guard_Finally", elements, Subjects.CallElementGuardFinally(array), elementExpected);
            passed &= CheckRow("Guard_Plain", elements, Subjects.CallElementGuardPlain(array), elementExpected);

            passed &= CheckRow("Guard_FinallyBlocked", elements, Subjects.CallElementGuardFinallyBlocked(array), elementExpected);
            passed &= CheckRow("Guard_PlainBlocked", elements, Subjects.CallElementGuardPlainBlocked(array), elementExpected);

            passed &= CheckRow("Foreach_Compiler", elements, Subjects.CallListForeach(list), listExpected);
            passed &= CheckRow("Foreach_Manual", elements, Subjects.CallListManual(list), listExpected);

            passed &= CheckRow("Foreach_CompilerBlocked", elements, Subjects.CallListForeachBlocked(list), listExpected);
            passed &= CheckRow("Foreach_ManualBlocked", elements, Subjects.CallListManualBlocked(list), listExpected);
        }

        Console.WriteLine();
        Console.WriteLine($"Обращений к счётчику: {Subjects.Touched}");
        Console.WriteLine(passed ? "Сверка прошла." : "Сверка не прошла.");

        return passed;
    }

    public static void PrintTiming()
    {
        Console.WriteLine($"Runtime: {Environment.Version}");
        Console.WriteLine($"Обходов списка за операцию: {Subjects.ListRounds}");
        Console.WriteLine($"Прогрев {WarmupMilliseconds} мс, замер {MeasureMilliseconds} мс на метод");

        Console.WriteLine();
        Console.WriteLine($"{"Метод",-26}{"Элементов",10}{"Вызовов",10}{"На вызов, нс",16}");

        foreach (int elements in Sizes)
        {
            int[] array = Subjects.CreateArray(elements);

            RunElementFinally(array, WarmupMilliseconds);
            TimingRow("Element_Finally", elements, elements, RunElementFinally(array, MeasureMilliseconds));

            RunElementPlain(array, WarmupMilliseconds);
            TimingRow("Element_Plain", elements, elements, RunElementPlain(array, MeasureMilliseconds));

            RunElementFinallyBlocked(array, WarmupMilliseconds);
            TimingRow("Element_FinallyBlocked", elements, elements, RunElementFinallyBlocked(array, MeasureMilliseconds));

            RunElementPlainBlocked(array, WarmupMilliseconds);
            TimingRow("Element_PlainBlocked", elements, elements, RunElementPlainBlocked(array, MeasureMilliseconds));

            RunElementGuardFinally(array, WarmupMilliseconds);
            TimingRow("Guard_Finally", elements, elements, RunElementGuardFinally(array, MeasureMilliseconds));

            RunElementGuardPlain(array, WarmupMilliseconds);
            TimingRow("Guard_Plain", elements, elements, RunElementGuardPlain(array, MeasureMilliseconds));

            RunElementGuardFinallyBlocked(array, WarmupMilliseconds);
            TimingRow("Guard_FinallyBlocked", elements, elements, RunElementGuardFinallyBlocked(array, MeasureMilliseconds));

            RunElementGuardPlainBlocked(array, WarmupMilliseconds);
            TimingRow("Guard_PlainBlocked", elements, elements, RunElementGuardPlainBlocked(array, MeasureMilliseconds));

            List<int> list = Subjects.CreateList(elements);

            RunListForeach(list, WarmupMilliseconds);
            TimingRow("Foreach_Compiler", elements, Subjects.ListRounds, RunListForeach(list, MeasureMilliseconds));

            RunListManual(list, WarmupMilliseconds);
            TimingRow("Foreach_Manual", elements, Subjects.ListRounds, RunListManual(list, MeasureMilliseconds));

            RunListForeachBlocked(list, WarmupMilliseconds);
            TimingRow("Foreach_CompilerBlocked", elements, Subjects.ListRounds, RunListForeachBlocked(list, MeasureMilliseconds));

            RunListManualBlocked(list, WarmupMilliseconds);
            TimingRow("Foreach_ManualBlocked", elements, Subjects.ListRounds, RunListManualBlocked(list, MeasureMilliseconds));
        }

        Console.WriteLine();
        Console.WriteLine($"Контрольная сумма: {_sink}");
    }

    private static bool CheckRow(string name, int elements, int actual, int expected)
    {
        Console.WriteLine($"{name,-26}{elements,10}{actual,14}{expected,14}");
        return actual == expected;
    }

    private static void TimingRow(string name, int elements, int calls, double nanoseconds) => Console.WriteLine($"{name,-26}{elements,10}{calls,10}{nanoseconds,16:F2}");

    private static double RunElementFinally(int[] data, int budget)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        long calls = 0;
        while (stopwatch.ElapsedMilliseconds < budget)
        {
            for (int i = 0; i < BatchSize; i++)
            {
                _sink = Subjects.CallElementFinally(data);
            }

            calls += BatchSize;
        }

        stopwatch.Stop();

        return stopwatch.Elapsed.TotalMilliseconds * 1_000_000.0 / calls;
    }

    private static double RunElementPlain(int[] data, int budget)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        long calls = 0;
        while (stopwatch.ElapsedMilliseconds < budget)
        {
            for (int i = 0; i < BatchSize; i++)
            {
                _sink = Subjects.CallElementPlain(data);
            }

            calls += BatchSize;
        }

        stopwatch.Stop();

        return stopwatch.Elapsed.TotalMilliseconds * 1_000_000.0 / calls;
    }

    private static double RunElementFinallyBlocked(int[] data, int budget)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        long calls = 0;
        while (stopwatch.ElapsedMilliseconds < budget)
        {
            for (int i = 0; i < BatchSize; i++)
            {
                _sink = Subjects.CallElementFinallyBlocked(data);
            }

            calls += BatchSize;
        }

        stopwatch.Stop();

        return stopwatch.Elapsed.TotalMilliseconds * 1_000_000.0 / calls;
    }

    private static double RunElementPlainBlocked(int[] data, int budget)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        long calls = 0;
        while (stopwatch.ElapsedMilliseconds < budget)
        {
            for (int i = 0; i < BatchSize; i++)
            {
                _sink = Subjects.CallElementPlainBlocked(data);
            }

            calls += BatchSize;
        }

        stopwatch.Stop();

        return stopwatch.Elapsed.TotalMilliseconds * 1_000_000.0 / calls;
    }

    private static double RunListForeach(List<int> data, int budget)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        long calls = 0;
        while (stopwatch.ElapsedMilliseconds < budget)
        {
            for (int i = 0; i < BatchSize; i++)
            {
                _sink = Subjects.CallListForeach(data);
            }

            calls += BatchSize;
        }

        stopwatch.Stop();

        return stopwatch.Elapsed.TotalMilliseconds * 1_000_000.0 / calls;
    }

    private static double RunListManual(List<int> data, int budget)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        long calls = 0;
        while (stopwatch.ElapsedMilliseconds < budget)
        {
            for (int i = 0; i < BatchSize; i++)
            {
                _sink = Subjects.CallListManual(data);
            }

            calls += BatchSize;
        }

        stopwatch.Stop();

        return stopwatch.Elapsed.TotalMilliseconds * 1_000_000.0 / calls;
    }

    private static double RunListForeachBlocked(List<int> data, int budget)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        long calls = 0;
        while (stopwatch.ElapsedMilliseconds < budget)
        {
            for (int i = 0; i < BatchSize; i++)
            {
                _sink = Subjects.CallListForeachBlocked(data);
            }

            calls += BatchSize;
        }

        stopwatch.Stop();

        return stopwatch.Elapsed.TotalMilliseconds * 1_000_000.0 / calls;
    }

    private static double RunListManualBlocked(List<int> data, int budget)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        long calls = 0;
        while (stopwatch.ElapsedMilliseconds < budget)
        {
            for (int i = 0; i < BatchSize; i++)
            {
                _sink = Subjects.CallListManualBlocked(data);
            }

            calls += BatchSize;
        }

        stopwatch.Stop();

        return stopwatch.Elapsed.TotalMilliseconds * 1_000_000.0 / calls;
    }

    private static double RunElementGuardFinally(int[] data, int budget)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        long calls = 0;
        while (stopwatch.ElapsedMilliseconds < budget)
        {
            for (int i = 0; i < BatchSize; i++)
            {
                _sink = Subjects.CallElementGuardFinally(data);
            }

            calls += BatchSize;
        }

        stopwatch.Stop();

        return stopwatch.Elapsed.TotalMilliseconds * 1_000_000.0 / calls;
    }

    private static double RunElementGuardPlain(int[] data, int budget)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        long calls = 0;
        while (stopwatch.ElapsedMilliseconds < budget)
        {
            for (int i = 0; i < BatchSize; i++)
            {
                _sink = Subjects.CallElementGuardPlain(data);
            }

            calls += BatchSize;
        }

        stopwatch.Stop();

        return stopwatch.Elapsed.TotalMilliseconds * 1_000_000.0 / calls;
    }

    private static double RunElementGuardFinallyBlocked(int[] data, int budget)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        long calls = 0;
        while (stopwatch.ElapsedMilliseconds < budget)
        {
            for (int i = 0; i < BatchSize; i++)
            {
                _sink = Subjects.CallElementGuardFinallyBlocked(data);
            }

            calls += BatchSize;
        }

        stopwatch.Stop();

        return stopwatch.Elapsed.TotalMilliseconds * 1_000_000.0 / calls;
    }

    private static double RunElementGuardPlainBlocked(int[] data, int budget)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        long calls = 0;
        while (stopwatch.ElapsedMilliseconds < budget)
        {
            for (int i = 0; i < BatchSize; i++)
            {
                _sink = Subjects.CallElementGuardPlainBlocked(data);
            }

            calls += BatchSize;
        }

        stopwatch.Stop();

        return stopwatch.Elapsed.TotalMilliseconds * 1_000_000.0 / calls;
    }
}
