@echo off
cd /d %~dp0

rem Один прогон целиком: сверка, замеры, замер без PGO, замер вне BenchmarkDotNet, листинги.

dotnet --list-runtimes | findstr /c:"Microsoft.NETCore.App 8." >nul || goto nortm
dotnet --list-runtimes | findstr /c:"Microsoft.NETCore.App 9." >nul || goto nortm
dotnet --list-runtimes | findstr /c:"Microsoft.NETCore.App 10." >nul || goto nortm

rem .NET 11 не обязателен: без него проект собирается на трёх рантаймах.

rem Отчёты прошлого прогона не удаляются сами, и два прогона смешиваются в одной папке.
if exist BenchmarkDotNet.Artifacts rd /s /q BenchmarkDotNet.Artifacts
if exist BenchmarkDotNet.Artifacts.NoPgo rd /s /q BenchmarkDotNet.Artifacts.NoPgo

dotnet build -c Release
if errorlevel 1 goto fail

rem Сверка ответов на каждом собранном рантайме. Расхождение останавливает прогон.
for %%F in (net8.0 net9.0 net10.0 net11.0) do (
    if exist "bin\Release\%%F\InliningEhProof.dll" (
        dotnet run -c Release -f %%F --no-build -- checks > checks_%%F.txt
        if errorlevel 1 goto fail
    )
)

dotnet run -c Release -f net10.0 --no-build -- --filter *
if errorlevel 1 goto fail

rem Тот же прогон с выключенным профилем: без него JIT не подставляет код
rem метода с try/finally, и это надо показать замером, а не словами.
set DOTNET_TieredPGO=0
dotnet run -c Release -f net10.0 --no-build -- --filter * --artifacts BenchmarkDotNet.Artifacts.NoPgo
set DOTNET_TieredPGO=

rem Замер вне BenchmarkDotNet: второй независимый счётчик под тот же результат.
for %%F in (net8.0 net9.0 net10.0 net11.0) do if exist "bin\Release\%%F\InliningEhProof.dll" dotnet run -c Release -f %%F --no-build -- timing > timing_%%F.txt

cd Disasm
dotnet build -c Release
if errorlevel 1 goto faildisasm

rem Diffable заменяет адреса на 0xD1FFAB1E, иначе листинги двух рантаймов не сравнить.
set DOTNET_JitDisasmDiffable=1
set DOTNET_JitDisasm=CallElementFinally CallElementPlain CallElementFinallyBlocked CallElementPlainBlocked CallElementGuardFinally CallElementGuardPlain CallElementGuardFinallyBlocked CallElementGuardPlainBlocked CallListForeach CallListManual CallListForeachBlocked CallListManualBlocked

bin\Release\net8.0\Disasm.exe  > disasm_net8.txt   2>&1
bin\Release\net9.0\Disasm.exe  > disasm_net9.txt   2>&1
bin\Release\net10.0\Disasm.exe > disasm_net10.txt  2>&1
if exist bin\Release\net11.0\Disasm.exe (bin\Release\net11.0\Disasm.exe > disasm_net11.txt 2>&1)

rem Тот же машинный код с выключенным профилем. Без него вывод про профиль
rem держится на одних числах.
set DOTNET_TieredPGO=0
bin\Release\net10.0\Disasm.exe > disasm_nopgo_net10.txt 2>&1
if exist bin\Release\net11.0\Disasm.exe (bin\Release\net11.0\Disasm.exe > disasm_nopgo_net11.txt 2>&1)
set DOTNET_TieredPGO=

set DOTNET_JitDisasm=
set DOTNET_JitDisasmDiffable=
cd ..

echo.
echo Gotovo:
echo   BenchmarkDotNet.Artifacts\results
echo   BenchmarkDotNet.Artifacts.NoPgo\results
echo   checks_net8.0.txt .. checks_net11.0.txt (net11 tolko s SDK 11)
echo   timing_net8.0.txt .. timing_net11.0.txt (net11 tolko s SDK 11)
echo   Disasm\disasm_net8.txt .. disasm_net11.txt
echo   Disasm\disasm_nopgo_net10.txt, disasm_nopgo_net11.txt
pause
exit /b 0

:nortm
echo Ne najden runtime 8, 9 ili 10.
pause
exit /b 1

:faildisasm
cd ..

:fail
echo Progon ostanovlen.
pause
exit /b 1
