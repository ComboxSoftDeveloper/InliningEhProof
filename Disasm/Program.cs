using InliningEhProof;

namespace Disasm;

/// <summary>
/// Прогрев вызывающих методов из Subjects, чтобы JIT дошёл до Tier1 и выдал
/// машинный код. Что снимать - задаётся в all.bat через DOTNET_JitDisasm.
/// В листинге ищется инструкция call на вызываемый метод: если её нет,
/// JIT подставил код метода в место вызова.
/// </summary>
internal static class Program
{
    private static void Main()
    {
        Console.WriteLine($"Runtime: {Environment.Version}");
        Console.WriteLine();

        const int elements = 4;
        const int warmup = 100_000;

        int[] array = Subjects.CreateArray(elements);
        List<int> list = Subjects.CreateList(elements);

        long sink = 0;
        for (int i = 0; i < warmup; i++)
        {
            sink += Subjects.CallElementFinally(array);
            sink += Subjects.CallElementPlain(array);
            sink += Subjects.CallElementFinallyBlocked(array);
            sink += Subjects.CallElementPlainBlocked(array);

            sink += Subjects.CallElementGuardFinally(array);
            sink += Subjects.CallElementGuardPlain(array);
            sink += Subjects.CallElementGuardFinallyBlocked(array);
            sink += Subjects.CallElementGuardPlainBlocked(array);

            sink += Subjects.CallListForeach(list);
            sink += Subjects.CallListManual(list);
            sink += Subjects.CallListForeachBlocked(list);
            sink += Subjects.CallListManualBlocked(list);
        }

        Console.WriteLine($"Контрольная сумма: {sink}");
    }
}
