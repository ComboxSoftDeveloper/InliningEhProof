using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace InliningEhProof.Benchmarks;

/// <summary>
/// Те же два метода, что в ElementEhBench, но без обращений к памяти:
/// вместо счётчика стоит проверка, которая не срабатывает. На машинах,
/// где запись в общее статическое поле занимает больше времени, чем вызов,
/// первый замер разницы не показывает, а этот показывает.
/// Параметр Elements - длина массива, она же число вызовов за операцию.
/// </summary>
[MemoryDiagnoser(false)]
[SimpleJob(RuntimeMoniker.Net80)]
[SimpleJob(RuntimeMoniker.Net90)]
[SimpleJob(RuntimeMoniker.Net10_0, baseline: true)]
public class GuardEhBench
{
    [Params(4, 16, 64)]
    public int Elements { get; set; }

    private int[] _data = null!;

    [GlobalSetup]
    public void Setup()
    {
        _data = Subjects.CreateArray(Elements);

        int expected = Subjects.ExpectedSum(Elements);

        Check(nameof(Subjects.CallElementGuardFinally), Subjects.CallElementGuardFinally(_data) == expected);
        Check(nameof(Subjects.CallElementGuardPlain), Subjects.CallElementGuardPlain(_data) == expected);

        Check(nameof(Subjects.CallElementGuardFinallyBlocked), Subjects.CallElementGuardFinallyBlocked(_data) == expected);
        Check(nameof(Subjects.CallElementGuardPlainBlocked), Subjects.CallElementGuardPlainBlocked(_data) == expected);
    }

    private static void Check(string name, bool ok)
    {
        if (!ok)
        {
            throw new InvalidOperationException($"{name}: сверка Setup не сошлась");
        }
    }

    [Benchmark(Baseline = true)]
    public int Guard_Finally() => Subjects.CallElementGuardFinally(_data);

    [Benchmark]
    public int Guard_Plain() => Subjects.CallElementGuardPlain(_data);

    [Benchmark]
    public int Guard_FinallyBlocked() => Subjects.CallElementGuardFinallyBlocked(_data);

    [Benchmark]
    public int Guard_PlainBlocked() => Subjects.CallElementGuardPlainBlocked(_data);
}
