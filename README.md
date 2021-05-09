# Pierre's Bakery Website: Vendor and Order Tracker

#### Epicodus Code Review #8: Basic Web Applications

#### By Shannon Lee

#### _Table of Contents_

1. [Description](#description)
2. [Technologies Used](#technologies)
3. [Setup/Installation Requirements](#setup)
4. [Additional Setup/Installation Note for Windows Users](#windows)
5. [Specifications](#specs)
6. [Known Bugs](#bugs)
7. [License](#license)
8. [Contact Information](#contact)


## Description <a id="description"></a>

Blah blah

## Technologies Used <a id="technologies"></a>

* C#
* .NET 5
* MSBuild
* MSTest
* git

## Setup/Installation Requirements <a id="setup"></a>

Setup requirements
* Make sure that .NET Software Development Kit 5 has been installed to your local machine. 

Installation
* Clone this repository to your machine `$ git clone https://github.com/shanole/PierresBakeryWebsite.Solution`
* In the terminal, navigate to the project directory `$ cd PierresBakeryWebsite.Solution/PierresBakeryWebsite`
* Compile code by running command `$ dotnet build`
* Run program with command `$ dotnet run` to open webpage on browser.

Running tests with MSTest
* Navigate to the tests directory `PierresBakeryWebsite.Solution/PierresBakeryWebsite.Tests`
* Run command `$ dotnet restore` to install MSTest frameworks
* Run command `$ dotnet test` to execute unit tests.


## Specifications <a id="specs"></a>

All unit testing was done with MSTest. To see full specs, 

Please refer to the .cs files in the `PierresBakeryWebsite.Solution/PierresBakeryWebsite.Tests/ModelTests` direct for a comprehensive breakdown of all specs for this project. All tests were run through MSTest.

__FILLER TEXT Unit testing for Bread class__
* For Bread constructor
  1. Bread constructor should return instance of Bread object.
  2. Getting the BreadOrders property should return number of orders of bread.
* For CalculatePrice() method
  1. 1 order of bread should equal $5
  2. 2 orders of bread should equal $10
  3. 3 orders of bread should equal $10
  4. 6 orders of bread should equal $20
  5. 7 orders of bread should equal $25


## Known Bugs <a id="bugs"></a>
* None known at this time. If you find one, please don't hesitate to contact me about it!

## License <a id="license"></a>
*[MIT](https://choosealicense.com/licenses/mit/)*

Copyright (c) 2021 Shannon Lee

## Contact Information <a id="contact"></a>
**_Shannon Lee [mailto](mailto:shannonleehj@gmail.com)_**