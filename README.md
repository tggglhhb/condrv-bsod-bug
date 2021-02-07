# condrv-bsod

Uses the condrv bug to crash Windows
> \\.\globalroot\device\condrv\kernelconnect

batch.bat: batch that runs the path as a comand (crashes)

bsod.exe: executable that behaves like the batch (crashes)

***The following executables can be potentially destructive, proceed with caution:***

- bsoduserstartup.exe: places a batch with the path inside in shell:startup ***and reboots*** (crash at login)

- bsodboot.exe: places itself in the syswow64 folder, adds the copied executable as a kernel service that runs at boot ***then reboots*** (crash at boot)
