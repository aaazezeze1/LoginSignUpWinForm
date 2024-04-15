# LoginSignUp
*Asynchronous Activity - C# Windows Form in ITEC 103. Assignment 3 = "Create a Create a simple  login and 
sign-up form using C# and Windows Forms"*. Made by Amazing Grace Cabiles from BSCS-1B.

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

# Possible problem 
For people that would like to modify this, one possible problem you'll encounter is Visual Studio not closing
the app or form even after closing it inside Visual Studio. **THIS IS A BUG OF VISUAL STUDIO NOT THE PROGRAM**
and the temporary fix for this is to open task manager, search for the app or form name and click on End task.