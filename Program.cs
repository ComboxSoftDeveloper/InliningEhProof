using System.Text;

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Running;
using InliningEhProof.Benchmarks;
using InliningEhProof.Diagnostics;

Console.OutputEncoding = Encoding.UTF8;

if (args.Contains("checks"))
{
    return Diagnostic.PrintChecks() ? 0 : 1;
}

if (args.Contains("timing"))
{
    Diagnostic.PrintTiming();
    return 0;
}

ManualConfig config = ManualConfig.Create(DefaultConfig.Instance)
    .AddExporter(MarkdownExporter.GitHub)
    .AddExporter(HtmlExporter.Default)
    .AddExporter(CsvExporter.Default);

Type[] benchmarks =
[
    typeof(ElementEhBench),
    typeof(GuardEhBench),
    typeof(ForeachEhBench),
];

BenchmarkSwitcher switcher = BenchmarkSwitcher.FromTypes(benchmarks);

if (args.Length > 0)
{
    switcher.Run(args, config);
    return 0;
}

switcher.RunAll(config);
return 0;

// Все замеры:          dotnet run -c Release -f net10.0
// Сверка ответов:      dotnet run -c Release -f net10.0 -- checks
// Замер без BDN:       dotnet run -c Release -f net10.0 -- timing
// Весь прогон:         all.bat
