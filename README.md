### Selenium GRID Implementation

#### Description: Implementation of Selenium GRID 4.0.  To be used for testing automationpractice.com website across multiple browsers.  Chrome, Firefox, and Edge.
Each test navigates through each browser to test the following functionalities:
Validate Login/Logout,
Validate Customer Service Message,
Validate Add/Edit Cart,
Validate add to wishlist,
Validate Search

##### Framework and References:
* .NET Framework
* C# Class Library
* Selenium.WebDriver
* Selenium.WebDriver.GeckoDriver
* Selenium.WebDriver.Chromedriver
* SeleniumWebDriver.MSEdgeDriver
* FluentAssertions

##### How to run selenium grid: 
* Download selenium-server-4.4.0 jar
* Run as Hub and Node
* Run in two command prompts.  One for hub.  One for node.
  * java -jar selenium-server-<version>.jar hub
  * java -jar selenium-server-<version>.jar node

By default, the server will listen for RemoteWebDriver requests on http://localhost:4444

##### Credits:  Ahmed Hernandez.  Assisted in multi browser driver configurations.

##### Challenges Faced:  Getting the correct configurations for SeleniumGrid.  Information on the web is outdated as previous configuration options have been deprecated.
