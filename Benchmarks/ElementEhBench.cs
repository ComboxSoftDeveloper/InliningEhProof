using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace InliningEhProof.Benchmarks;

/// <summary>
/// Сравнивает два вызываемых метода с одинаковым кодом: чтение элемента
/// массива и увеличение счётчика. У одного счётчик увеличивается в finally,
/// и в IL появляется блок обработки исключений. Методы Blocked повторяют
/// то же самое с запретом на подстановку кода. Параметр Elements - длина
/// массива, она же число вызовов за одну операцию.
/// </summary>
[MemoryDiagnoser(false)]
[SimpleJob(RuntimeMoniker.Net80)]
[SimpleJob(RuntimeMoniker.Net90)]
[SimpleJob(RuntimeMoniker.Net10_0, baseline: true)]
public class ElementEhBench
{
    [Params(4, 16, 64)]
    public int Elements { get; set; }

    private int[] _data = null!;

    [GlobalSetup]
    public void Setup()
    {
        _data = Subjects.CreateArray(Elements);

        int expected = Subjects.ExpectedSum(Elements);

        Check(nameof(Subjects.CallElementFinally), Subjects.CallElementFinally(_data) == expected);
        Check(nameof(Subjects.CallElementPlain), Subjects.CallElementPlain(_data) == expected);

        Check(nameof(Subjects.CallElementFinallyBlocked), Subjects.CallElementFinallyBlocked(_data) == expected);
        Check(nameof(Subjects.CallElementPlainBlocked), Subjects.CallElementPlainBlocked(_data) == expected);
    }

    private static void Check(string name, bool ok)
    {
        if (!ok)
        {
            throw new InvalidOperationException($"{name}: сверка Setup не сошлась");
        }
    }

    [Benchmark(Baseline = true)]
    public int Element_Finally() => Subjects.CallElementFinally(_data);

    [Benchmark]
    public int Element_Plain() => Subjects.CallElementPlain(_data);

    [Benchmark]
    public int Element_FinallyBlocked() => Subjects.CallElementFinallyBlocked(_data);

    [Benchmark]
    public int Element_PlainBlocked() => Subjects.CallElementPlainBlocked(_data);
}
