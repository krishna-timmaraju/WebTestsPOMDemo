#### Overview
Implementation of sample Web Functional tests (for a dummy ecommerce application) to demonstrate usage of Page Object Model and Factory design patterns in Test Automation

#### Approach
 - UI Framework is designed using Page Object Model and Factory design patterns
 - A corresponding Page Object is defined for each web page / view / iframe with all the web elements and their related actions.
 - A DriverFactory class instantiates the corresponding Web Driver (per browser).

#### Tech Stack
 - .NET Core platform (cab be run in Linux and Windows)
 - C#
 - Selenium
 - NUnit
 - Visual Stuido Code IDE

#### Running the Tests
 - **Windows**:
      - Install .NET Core from here - https://dotnet.microsoft.com/download/dotnet-core/current/runtime

 - **Linux**: 
      - Install .NET core using the following commands:
         > wget https://packages.microsoft.com/config/ubuntu/16.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
         > sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-3.1
      - Unzip the _Linux-Test-Binaries.zip_ to a folder in the Linux machine (I tested in Linux 16.04 LTS version)

 - **To change the Browser for running the tests** : After unzipping the binaries from the above step, Open _TestData.json_ and change the _browser_ key to "firefox" (or) "chrome"

#### Future Improvements
 - Implement Retry logic to handle flakiness
 - Custom Reporting to include charts and graphs
