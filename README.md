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

##### Pre-requisites and Environment

##### To-Do

#### Potential Improvements