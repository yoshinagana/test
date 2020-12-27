@echo off
set NET35=%WINDIR%\Microsoft.NET\Framework\v3.5
set NET40=%WINDIR%\Microsoft.NET\Framework\v4.0.30319
set PATH=%NET40%;%NET35%;%PATH%
sc config "Service1" displayname= "Test Service"
pause
