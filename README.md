# AquaOS
Aqua OS is a basic os with a cli, written in c#.
Aqua OS is based on CosmosOS: gocosmos.org.

Features:
FAT FileSystem
Text editor(work-in-progress)
Basic OS commands

## Newest feature: Aquapps!
Aquapps are __very__ simple applications written in the ASCS coding language,
a __very__ simplified version of C#. Read below to learn how to make an aquapp!

## How to try:
To try out AquaOS: 
1. Download the iso file (CosmosKernel5 does not support aquapps) (inside the zip folder) and vmdk file above.
2. Download VMWare.
3. Create a new virtual machine.
4. For the OS, choose other.
5. Finish setup and go into settings.
6. Delete the existing hard disk and add a new one.
7. Choose to add an existing hard disk, and add the Filesystem.vmdk file that you downloaded in step 1.
8. Enjoy!

## How to create Aquapps:
Materials:
A working version of AquaOS version 0.32 or higher.
Knowledge!

### Steps:
1. Learn the commands of ASCS (there aren't many):
write(texttowrite)
writeline(texttowrite)
inputget(texttowrite) <- creates variable with input called usrinput
sayinput()
newline()
2. Write a program
3. Add info to the beggining of the script like this:
info = yourinfohere
4. Example aquapp:
info = Example app version 100,001 by Example McMaker
5. REMEMBER: Code the app in AquaOS, using Scribbler.
6. Run your app!

_Note: The info part is not required, but when an aquapp is run on AquaOS, it will display that info before starting the aquapp._

## To make your own AquaOS:
To fork a project off of AquaOS:
1. Download the Kernel.cs file.
2. Follow instruction from gocosmos.org to download & install Visual Studio and Cosmos.
3. Make a new Visual Studio project with the Cosmos c# kernel template.
4. Copy and paste my kernel to the kernel you just created.
5. Change it up, and the run it!

## Images:
![image of aquaos](https://github.com/pikalover6/AquaOS/blob/Images/SNIP.PNG?raw=true)
