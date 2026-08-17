using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace InliningEhProof.Benchmarks;

/// <summary>
/// Сравнивает два вызываемых метода, которые обходят один список и вызывают
/// Dispose у перечислителя. У одного обход написан через foreach, и try/finally
/// добавляет компилятор. Методы Blocked повторяют то же самое с запретом
/// на подстановку кода. Параметр Elements - длина списка, за одну операцию
/// список обходится Subjects.ListRounds раз.
/// </summary>
[MemoryDiagnoser(false)]
[SimpleJob(RuntimeMoniker.Net80)]
[SimpleJob(RuntimeMoniker.Net90)]
[SimpleJob(RuntimeMoniker.Net10_0, baseline: true)]
public class ForeachEhBench
{
    [Params(4, 16, 64)]
    public int Elements { get; set; }

    private List<int> _data = null!;

    [GlobalSetup]
    public void Setup()
    {
        _data = Subjects.CreateList(Elements);

        int expected = Subjects.ExpectedSum(Elements) * Subjects.ListRounds;

        Check(nameof(Subjects.CallListForeach), Subjects.CallListForeach(_data) == expected);
        Check(nameof(Subjects.CallListManual), Subjects.CallListManual(_data) == expected);

        Check(nameof(Subjects.CallListForeachBlocked), Subjects.CallListForeachBlocked(_data) == expected);
        Check(nameof(Subjects.CallListManualBlocked), Subjects.CallListManualBlocked(_data) == expected);
    }

    private static void Check(string name, bool ok)
    {
        if (!ok)
        {
            throw new InvalidOperationException($"{name}: сверка Setup не сошлась");
        }
    }

    [Benchmark(Baseline = true)]
    public int Foreach_Compiler() => Subjects.CallListForeach(_data);

    [Benchmark]
    public int Foreach_Manual() => Subjects.CallListManual(_data);

    [Benchmark]
    public int Foreach_CompilerBlocked() => Subjects.CallListForeachBlocked(_data);

    [Benchmark]
    public int Foreach_ManualBlocked() => Subjects.CallListManualBlocked(_data);
}
