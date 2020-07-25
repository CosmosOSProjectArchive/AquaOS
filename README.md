## NOTE: PLEASE DON'T USE THIS CODE IT IS OLD AND SPAGHETTI.  THIS IS HERE FOR HISTORICAL PURPOSE 

# AquaOS
Aqua OS is a basic os with a cli, written in c#.

![image of aquaos](https://github.com/pikalover6/AquaOS/blob/Images/bootscreen.PNG?raw=true)

Aqua OS is based on CosmosOS: gocosmos.org.

Features:
FAT FileSystem

Text editor(work-in-progress)

Basic OS commands

Aquapps!

## (New) feature: Aquapps!
Aquapps are __very__ simple applications written in the ASCS coding language,
a __very__ simplified version of C#.

Aquapp files are files ending in .aquapp, .aquaa, .scaqp and .ascsa.

Read below to learn how to make an aquapp!

## What's new (for 0.40 kernel):
1. Eraser, an app to erase text from files!
2. Scribbler improvements and bug fixes.
3. Dev mode removed.
4. FileSystem bug fixes! (subdirectories still not supported)
5. Cool boot improvements. (better logo, and a boot animation)
6. Sound!
7. Exception handling.
8. More than _400_ lines of code!
9. Some easter eggs...

## How to try:
To try out AquaOS: 
1. Download the iso file (inside the zip folder) and vmdk file above.
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

_Note: The info part is not required, but when an aquapp is run on AquaOS, it will display that info before starting the aquapp.

## To make your own AquaOS:
To fork a project off of AquaOS:

Prerequisites:
Visual Studio 2019, 
AquaOS Userkit, 
.NET core and 
VMWare workstation player

1. Download the Kernel of your choice to: C:\Users\[yourusername]\source\repos\AquaOS\AquaOS\.
2. Dowload the solution file to: C:\Users\[yourusername]\source\repos\AquaOS\.
3. Open up the solution.
4. Change it.
5. Press the build option and it will build for you!*

*After the build is done it will launch a VM window, if you are looking for the .iso file it is located in:

C:\Users\\[yourusername]\source\repos\AquaOS\AquaOS\bin\Debug\netcoreapp2.0\cosmos\

## Images:
![image of aquaos](https://github.com/pikalover6/AquaOS/blob/Images/welcome.png?raw=true)
![image of aquaos](https://github.com/pikalover6/AquaOS/blob/Images/booted.PNG?raw=true)
![image of aquaos](https://github.com/pikalover6/AquaOS/blob/Images/SNIP.PNG?raw=true)
