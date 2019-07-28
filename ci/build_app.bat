cd source-code-repository
powershell.exe -NoProfile -ExecutionPolicy unrestricted -Command "& { Invoke-Command '.\build_app.ps1' %1; if ($lastexitcode -ne 0) {write-host "ERROR: $lastexitcode" -fore RED; exit $lastexitcode} }" 

