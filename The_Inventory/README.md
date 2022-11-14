<!-- REPLACE ALL THE [userHP200104] TEXT WITH YOUR GITHUB PROFILE NAME & THE [The_Inventory] WITH THE NAME OF YOUR GITHUB PROJECT -->

<!-- Repository Information & Links-->
<br />

![GitHub repo size](https://img.shields.io/github/repo-size/userHP200104/The_Inventory?color=%000000)
![GitHub watchers](https://img.shields.io/github/watchers/userHP200104/The_Inventory?color=%000000)
![GitHub language count](https://img.shields.io/github/languages/count/userHP200104/The_Inventory?color=%000000)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/userHP200104/The_Inventory?color=%000000)
[![LinkedIn][linkedin-shield]][linkedin-url]
[![Behance][behance-shield]][behance-url]

<!-- HEADER SECTION -->
<h5 align="center" style="padding:0;margin:0;">Hansin Prema</h5>
<h5 align="center" style="padding:0;margin:0;">200104</h5>
<h6 align="center">Interactive Development 300</h6>
</br>
<p align="center">

  <a href="https://github.com/userHP200104/The_Inventory">
    <img src="readMeAssets/logo.png" alt="Logo">
  </a>
  
  <h3 align="center">The_Inventory</h3>

  <p align="center">
    Chemical Manufacturer Stock Inventory<br>
      <a href="https://github.com/userHP200104/The_Inventory"><strong>Explore the docs »</strong></a>
   <br />
   <br />
    <a href="https://github.com/userHP200104/The_Inventory/issues">Report Bug</a>
    ·
    <a href="https://github.com/userHP200104/The_Inventory/issues">Request Feature</a>
</p>
<!-- TABLE OF CONTENTS -->

## Table of Contents

* [About the Project](#about-the-project)
  * [Project Description](#project-description)
  * [Built With](#built-with)
* [Getting Started](#getting-started)
  * [Prerequisites](#prerequisites)
  * [How to install](#how-to-install)
* [Features and Functionality](#features-and-functionality)
* [Concept Process](#concept-process)
   * [Ideation](#ideation)
   * [Wireframes](#wireframes)
   * [User-flow](#user-flow)
* [Development Process](#development-process)
   * [Implementation Process](#implementation-process)
        * [Highlights](#highlights)
        * [Challenges](#challenges)
   * [Future Implementation](#future-implementation)
* [Roadmap](#roadmap)
* [Contributing](#contributing)
* [License](#license)
* [Contact](#contact)
* [Acknowledgements](#acknowledgements)

<!--PROJECT DESCRIPTION-->
## About the Project
<!-- header image of project -->
![image5][image5]

### Project Description

A chemical inventory for Chem Co. which allows you to pay raw chemicals and make chemical compounds as well as manage the inventory of multiple warehouses.

### Built With

* [ASP.NET](https://dotnet.microsoft.com/en-us/apps/aspnet)
* [mySQL database](https://www.mysql.com/)
* [Visual Studio](https://visualstudio.microsoft.com/vs/mac/)
* [GitHub](https://github.com/)
* [Mamp](https://www.mamp.info/en/mac/)

<!-- GETTING STARTED -->
<!-- Make sure to add appropriate information about what prerequesite technologies the user would need and also the steps to install your project on their own mashines -->
## Getting Started

The following instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

Ensure that you have the latest version of [Visual Studio](https://visualstudio.microsoft.com/vs/mac/) installed on your machine.
### How to install

### Installation
Here are a couple of ways to clone this repo:

1. Clone Repository </br>
Run the following in the command-line to clone the project:
   ```sh
   git clone https://github.com/userHP200104/The_Inventory.git
   ```
    Open `Software` and select `File | Open...` from the menu. Select cloned directory and press `Open` button.

3. Start your [MAMP](https://www.mamp.info/en/mac/) Server.

4. Export the [TheInventory.sql](readMeAssets/TheInventory.sql) file to your [myPHPAdmin](http://localhost:8888/phpMyAdmin5/).

4. Make sure to change the access_key using SHA2('your_access_key') in the chemical and reaction tables using:
   ```sql
   UPDATE chemicals SET access_key = SHA2('your_access_key');
   UPDATE reaction SET access_key = SHA2('your_access_key');
   ```

4. In the Services folder open Database.cs and change the database connection string :
   ```sh
      private static string serverConfiguration = @"server=localhost;port=8889 userid=root;password=root;database=TheInventory";
   ```

5. To get the required NuGet packages right-click on the `Dependencies Folder` and click on `Restore`.

6. To run the project click on `Play Button`.


<!-- FEATURES AND FUNCTIONALITY-->
<!-- You can add the links to all of your imagery at the bottom of the file as references -->
</br>

## Features and Functionality
### Home

From this page the user can see what chemicals are almost out of stock. They can choose to buy more from this page. You can

In the side navigation you can also view which ware house you are in and how many resources are available.

![image2][image2]

### Lab

From this page you can veiw all the chemical you have in stock and in the reaction lab you can react raw chemical to form chemical componunds.

To buy or react you need to have an authorisation code to move forward with the tranaction or reaction.

![image3][image3]

### Warehouse

From this page you can view the stock of all the warehouse. You can also change your location from this page to manage the inventories of the other locations.

![image4][image4]


<!-- CONCEPT PROCESS -->
<!-- Briefly explain your concept ideation process -->
## Concept Process

### Ideation

### Wireframes

![image8][image8]

### User-flow

![image7][image7]

### Entity–Relationship Diagram

![image6][image6]

<!-- DEVELOPMENT PROCESS -->
## Development Process

The `Development Process` is the technical implementations and functionality done in the frontend and backend of the application.

### Implementation Process
<!-- stipulate all of the functionality you included in the project -->

* Project created and `Frontend` implemented.
* `SQL Database` set up and link using `MAMP` and `MyPhpAdmin`.
* `CRUD` added to the chemical stock.


#### Highlights
<!-- stipulated the highlight you experienced with the project -->
* This was a very fun project and challenging project to create since it was my first time coding in C# and ASP.NET.

#### Challenges
<!-- stipulated the challenges you faced with the project and why you think you faced it or how you think you'll solve it (if not solved) -->
* Making calls to the `Database`. This took some time to solve but once I got it right it was easy to continue implementing it.


### Future Implementation
<!-- stipulate functionality and improvements that can be implemented in the future. -->

* Trading chemicals between warehouses.


<!-- ROADMAP -->
## Roadmap

See the [open issues](https://github.com/userHP200104/The_Inventory/issues) for a list of proposed features (and known issues).

<!-- CONTRIBUTING -->
## Contributing

Contributions are what makes the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<!-- AUTHORS -->
## Authors

* **Your Name & Surname** - userHP200104(https://github.com/userHP200104)

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.

<!-- LICENSE -->
## Contact

* **Hansin Prema** - [hansinprema@gmail.com](mailto:hansinprema@gmail.com) 
* **Project Link** - https://github.com/userHP200104/The_Inventory

<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
<!-- all resources that you used and Acknowledgements here -->
* [ASP.NET Docs](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-7.0)


<!-- MARKDOWN LINKS & IMAGES -->
[image1]: readMeAssets/Logo.png
[image2]: readMeAssets/1.png
[image3]: readMeAssets/2.png
[image4]: readMeAssets/3.png
[image5]: readMeAssets/cover.png
[image6]: readMeAssets/ERD.png
[image7]: readMeAssets/User%20Flow.png
[image8]: readMeAssets/wireframes.png


<!-- Refer to https://shields.io/ for more information and options about the shield links at the top of the ReadMe file -->
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/hansin-prema-b474401a1/
[behance-shield]: https://img.shields.io/badge/-Behance-black.svg?style=flat-square&logo=behance&colorB=555
[behance-url]: https://www.behance.net/hansinprema1
