# condrv-bsod

Uses the condrv bug to crash Windows
### \\.\globalroot\device\condrv\kernelconnect
<br/>
<br/>
bsoduserstartup.exe: places a batch with the path inside in shell:startup (crash at login)
<br/>
bsodsystemstartup.exe: places a batch with the path inside in the system startup folder, requires admin rights to create the batch (crash at boot)
<br/>
url.url: url to the path
<br/>
batch.bat: batch with path
<br/>
bsod.exe: executable that works like the batch
