# LoginSignUp
*Asynchronous Activity - C# Windows Form in ITEC 103. Assignment 3 = "Create a Create a simple  login and 
sign-up form using C# and Windows Forms"*. Made by Amazing Grace Cabiles from BSCS-1B.

# Project Showcase

Unhandled Exception (Visual Studio Bug)
https://github.com/aaazezeze1/LoginSignUpWinForm/assets/81816019/9a6040c2-cae4-45f3-9682-2701397d55d1

Background Process even after Closing (Visual Studio Bug)
https://github.com/aaazezeze1/LoginSignUpWinForm/assets/81816019/f982c5ee-9166-469e-9b50-7de15e0ef1fb

# What was used for this assignment
1. Microsoft Visual Studio 2022 (.NET 8)
2. Built in Libraries of C#
3. System.Data.OleDb by Microsoft (Version 8.0.0)
4. Microsoft Access Database Engine 2016 Redistributable (X64 Version)
5. Microsoft Access Database Software

***NOTE: 
The Microsoft Access Database Engine has to be the X64 bit version for it to work with Visual Studio 2022
as Visual Studio 2022 does not support x86 for OleDb.***

# How to setup 
1. Install System.Data.OleDb first using NuGet in Visual Studio. Go to Project then Manage NuGet Packages
then search for System.Data.OleDb by Microsoft
2. Install Microsoft Access Database Software and the Database Engine for X64 bit Systems
3. Follow the steps here to [Setup OleDb](https://stackoverflow.com/questions/76831193/how-do-i-fix-the-error-microsoft-ace-oledb-12-0-provider-is-not-registered-on)
Link for Downloading the [Database Engine](https://www.microsoft.com/en-us/download/details.aspx?id=54920)

# Possible problems
For people that would like to modify this, one possible problem you'll encounter is getting an 
unhandled exception when the code is working just fine or Visual Studio not closing the app or 
form even after closing it inside Visual Studio. 

**THESE ARE BUGS OF VISUAL STUDIO AND NOT THE PROGRAM**
The temporary fix for both of these problems is to open task manager, search for the app or form name 
and click on End task then run the program again.

***PS: I have tried running the program multiple times and sometimes it would work while it is open 
multiple times in the background and when the password has to be inputted twice for verification.
In other times though, I get an Unhandled Exception on the password verification and the program
would not run because a "copy" is open meaning it didn't fully close which can be seen in the task manager***
