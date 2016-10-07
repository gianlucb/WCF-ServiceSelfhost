# Selfhost WCF service

Basic implementation of a selfhosted WCF service. WCF tracing is enabled in configuration file.

# ETW tracing
- **logman  start WCFETWTracing -p "Microsoft-Windows-Application Server-Applications"  -nb 256 1024 -bs 512 -ets -ct perf -f bincirc -max 500 -o mywcftrace.etl**
- _execute the program_
- **logman.exe stop WCFETWTracing –ets**
- **netsh trace convert input=mywcftrace.etl wcf_repro.txt TXT**