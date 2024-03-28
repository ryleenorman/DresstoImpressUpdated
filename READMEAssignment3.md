# Dress to Impress SQL 
**Beginner SQL Coding for Stored Procedures assignment for WVU MIST 353** 


# **Table of Contents**

- [Introduction](#introduction)

- [Page Overview](#pageOverview)

- [Message Statement](#MessageStatement)

- [Improvements](#improvements)

- [Stored Procedures](#storedprocedures)

- [Installation](#installation)

- [Contributing](#contributing)

- [Conclusion](#conclusion)

## Introduction 

**This is a SQL assignment meant to grasp a better understanding in stored procedures and integration of SQL into a website in the future.**  
## **Page Overview**

**Within the SQL assignment, students were tasked with making six stored procedures to be able to integrate into their website.  With our fashion website, we integrated features such as a cart and fetching the details of items inside the database.**

## **Message Statement**
**We are excited to announce our innovative approach to enhancing user experience with our new application. By merging our website, we are streamlining the process of outfit selection. Users can now enjoy a personalized experience, with outfits curated based on their preferences, occasion type, and real-time weather data. Whether it's casual, formal, or professional attire, our unique algorithm takes into account the current weather conditions to ensure that outfits are not only stylish but also suitable for the day's forecast. From suggesting light layers for a sunny day to recommending a cozy coat for cooler temperatures, our app provides users with outfits that are both fashionable and weather-appropriate. Additionally, our algorithm prevents repeat selections by offering outfits at random, providing users with fresh and exciting choices every time. We are confident that this integration will revolutionize the way our customers engage with fashion, making it easier and more enjoyable than ever before.**

## **Improvements**

-   **Integrating the stored procedures into a web-based environment**
    
-   **Needed weather data to be able to make the website more functional**
    
-   **Machine-learning adaptation for the user to be able to interact with the website to create a lookbook**

-   **Application data to move to mobile development**

### Stored Procedures

1. spGetCartDetails
    * Description: Get all details for cart using CartID. Used to generate data for a user’s cart information.
2. spGetUserOccupation
    * Description: Get the occupation of the user based off their UserID.   
3. spGetWeatherByTemp
    * Description: Get details from the weather using the temperature. Used to generate past weather data based on temperature inquiry.
4. spGetOutfitDetails
    * Description: Get all details for each outfit using OutfitID. Used to generate all data related to each outfit. (occasion, clothing type, etc.)
5. spGetClothingBySeason
    * Description: Get details for a piece of clothing based on season selection. Used to generate all pieces of clothing in the database based on season inquiry.
6. spGetClothingLessThan20
    * Description: Get details for each piece of clothing priced under $20. Used to generate all pieces of clothing in the database that have a price less than $20.

## **Installation**

**Users can use the code provided within the GitHub repository to use in a starter code in an IDE. This code is simplistic and can be integrated into a web application after more advanced safety features for the user are added.**

## **Contributing**

**This application was developed for a learning environment at West Virginia University.**

**Sources include:**

**Lectures by Joshua Meadows: WVU**

**https://www.w3schools.com/**

**https://chat.openai.com/c/a953150b-49a6-4572-b060-fe3293198f2e**

-   **ChatGPT was referenced to find errors in code throughout the development process. The prompts were “Fix this code to not run with errors” followed by the code**
    
-   **ChatGPT was also referenced to gain more knowledge about what should be in a readme. The prompt was “what should be put in a readme” and “readme template”**

# **Conclusion**
**The application is currently in the opening stages and will need significant improvements to functional.   This assignment is strictly for learning and assignment submission for the MIST 353 class at West Virginia University.**
