#ETW tracing for WCF (machine-wide)
Write-Host "Enabling WCF tracing (Machine-wide)"

$startCmd = 'logman start WCFETWTracing -p "Microsoft-Windows-Application Server-Applications"  -nb 256 1024 -bs 512 -ets -ct perf -f bincirc -max 500 -o mywcftrace.etl'
$stopCmd = 'logman.exe stop WCFETWTracing -ets'
$convertCmd = 'netsh trace convert input=mywcftrace.etl wcf_repro.txt TXT overwrite=yes'
$notepadCmd = 'notepad wcf_repro.txt'

Invoke-Expression -Command $startCmd

Write-Host "WCF tracing enabled" -ForegroundColor Green
Write-Host "Reproduce your problem and press enter" -ForegroundColor Yellow
Read-Host 'Press Enter to continue…'

Invoke-Expression -Command $stopCmd
Invoke-Expression -Command $convertCmd
Invoke-Expression -Command $notepadCmd



