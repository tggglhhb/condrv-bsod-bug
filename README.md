# condrv-bsod

Uses the condrv bug to crash Windows
> \\.\globalroot\device\condrv\kernelconnect

url.url: url to the path

batch.bat: batch with path

bsod.exe: executable that works like the batch

***The following executables can be potentially destructive, proceed with caution:***

- bsoduserstartup.exe: places a batch with the path inside in shell:startup ***and reboots*** (crash at login)

- bsodsystemstartup.exe: places itself in the syswow64 folder, adds the copied executable as a kernel service that boots at startup ***then reboots*** (crash at boot)
