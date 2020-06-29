#### UI Automation Framework for MindTrans Sample Store

##### Overview
This source code repository consists of Test Scripts to verify the Successful and Failed transactions for a Buy flow of a product in MindTrans Sample Store website. 

##### Brief Description
The framework contains two test scripts namely VerifyPurchasePillow and VerifyFailedPurchasePillow. The first script verifies the end-to-end checkflow with successful payment transaction and the second script verifies with a failed payment transaction.

##### Approach
 - UI Framework is designed using Page Object Model and Factory Design Pattern
 - High-level architecuture diagram is attached in a .pdf file along with the solution.
 - Tests are designed to run in Chrome and Firefox browsers.
 - A corresponding Page Object is defined for each web page / view / iframe with all the web elements and their related actions.
 - A DriverFactory class instantiates the corresponding Web Driver (per browser).
 - Tests are defined in a seperate class, thereby seperating the test actions and the page under test.

##### Tech Stack
 - .NET Core platform
 - C# language
 - Selenium framework for web tests
 - NUnit framework for test development

##### Source Code of the Tests
 - Code can be navigated using Visual Stuido Code IDE (free download for both Windows and Linux systems)
 - Download Visual Studio Code : https://code.visualstudio.com/download
 - Unzip the Test-Source.zip on a Windows machine
##### Running the Tests
 - install .NET Core from here - https://dotnet.microsoft.com/download/dotnet-core/current/runtime
 - Unzip the Windows-Test-Binaries.zip to a folder in the machine
 - Change Directory to the above folder and run the following command for Successful Payment Test:(Check if MidTransTests.dll is present)
    > dotnet test MidTransTests.dll --filter Name=VerifyPurchasePillow
 - Change Directory to the above folder and run the following command for Failed Payment Test:(Check if MidTransTests.dll is present)
    > dotnet test MidTransTests.dll --filter Name=VerifyFailedPurchasePillow
 - By default, the browser is set to chrome

##### To-Do Areas
 - **Custom Reporting** - could not implement due to time constraints as of today (29/6/2020). But. I have some ideas to extend a framework (ExtentReports) and present the results in HTML format.

##### More fine-grain Improvement Areas
 - Observed during my test development and test runs, the iframe displayed during the Bank OTP screen is flaky - sometimes getting iframe not present error