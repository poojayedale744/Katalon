# Qualitest - Codility Test

Hi! This is my submission for the **Qualitest** test as part of interview process


# Setup

This project uses is built using **C#, Selenium Webdriver, SpecFlow and Nunit** with the intention to run on Chrome browser.

To run this project locally, you will need:
* Microsoft Visual Studio 2022 
* Clone/Download the project from Github
* Based on your chrome version installed on your local machine, download the appropriate ChromeDriver from [here](https://chromedriver.chromium.org/downloads) and place it at the root of project directory
* Sign up for a [Specflow](https://docs.specflow.org/en/latest/specflowaccount.html) account

# Running the project
* Once you have completed above setup, open the **Katalon.sln** solution file in Visual Studio.
* Restore the nuget packages if not done automatically
* Clean and build the project
* You should get the test explorer tab - right click on the test to run it which will launch Chrome and run the automation test

## Suggestions for further improvements

* Unique identifier to the web elements could be added by development team
* The sleep() method could be replaced by implicit/explicit wait 
* Support for more browsers can be added