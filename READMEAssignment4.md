## Our Six Pages:


### Index (Home Page)

The first page you land on when launching the website is the Index or Home Page. This page is composed of two Hero Images with buttons that take you to the two other pages and also descriptions of these pages. It is meant to be the most aesthetically pleasing page, as it is the first thing you see. While building this page I wanted to showcase more of a “brand image” or a certain type of branding to match with the name of the website. I used a good bit of custom CSS throughout the pages for different things, such as buttons or dividers to give a cleaner look. I also used the “Lux” theme from Bootswatch, as I also thought it was fitting for the brand image. Some of the code inspiration and research from this part of the website comes from W3Schools, such as the hero images and the dividers. After going to any of the other pages, you can navigate back to the home page by clicking the “Home” button in the navigation bar.


### Outfit Results

This page is linked to the first hero image button on the Home Page. This is where the user will go to get their generated outfit for the day. The page is made up of a two column layout from W3Schools. Currently, there is an anchored button that will take the user to the Weather Channel’s website to check their weather for that area. The next section there is a button that will randomly generate an outfit every time the user clicks the button. The function used is JavaScript that puts uploaded images from the developer into an array that chooses one at random each time. This was a personal idea that ChatGPT was able to clean up and help make my code functional. This is also where we plan to implement the NOAA weather APIs to display weather or retrieve data to give our customers better outfit predictions.


### Look Book

This page is linked to the second hero image button on the Home Page. This is where the user can go to get season inspiration, more about the “brand image” and favorite picks from the creator. I wanted this page to give more personality to the brand and almost give the feel of a blog but a more refined and sophisticated version. It is composed of a four column layout also from W3Schools, for each of the four seasons of the year. At the bottom of the page there is a table with more details about inspiration for the outfit picks from the creator, which includes individuals known for their wardrobe picks, what their occupation was and what time period they are from. The table I used is one from the Bootstrap section on W3Schools. I also used a lot of my header tags throughout this page such as &lt;h1> and &lt;h2>.


### Privacy Policy

This will be one of our non-dynamic pages. The privacy policy will be the fourth page for our website and will include important topics for our customers to be aware of. These topics usually include use of cookies, use of customer location, customer data collection (including payment information), and how we disclose personal information. This will be a relatively simple and “boring” page, but important nonetheless to be transparent with data for customers.


### Shopping Cart

The next page for our “Dress to Impress” website will be a page for our customers’ cart. Because we generate outfits for our customers, we will also partner with brands so they can directly purchase the pieces from our website. Not only is this more convenient for customers so they don’t have to search for clothing on multiple websites, but we can also bring in revenue by promoting different brands and their items on our website. This will allow us to have multiple streams of income if we were to decide to also implement a subscription or member structure for customers.


### All/Add Clothing

This page will act as a reference page for all clothing on our website and a place for brands or companies to input their own items. This page will be implementing User Generated Content, but instead of customers or normal people, this will be someone working for a specific brand as a partner to our website. UGC allows us (Dress to Impress) to not have to find content on our own, but also provide a source of income. Brands will be able to upload pictures and prices of their products after (hopefully) entering specific log-in information to prevent SQL injection or malicious intent from a customer or someone visiting our site.


## API Documentation:


### ClothingSeasonService (Rylee Norman)


#### What It Does

This API takes an input of ClothingID and returns the Season of the piece of clothing. This is helpful because our outfits are generated based on the outdoor conditions for the day. You do not want to recommend someone a tank top in the winter.


#### Inputs



*  {ClothingID}: The unique identifier for each piece of clothing


#### Outputs

Returns the ClothingID and Clothing Season



* int UserID
* String ClothingSeason


### OutfitService (Emily Mago)


#### What It Does

This API takes an input of OutfitID and returns all the details for that specific outfit. This is helpful because we have certain data in the table that will allow us to recommend different outfits for different people. For example, which outfit is for which weather conditions? Or which outfit is best for a formal occasion?


#### Inputs



*  {OutfitID}: The unique identifier for each outfit


#### Outputs

Returns the OutfitID, WeatherID, ClothingID, OutfitOccasion



* int OutfitID
* int WeatherID
* int ClothingID
* string OutfitOccasion


### UserOccupationService (Emily Surface)


#### What It Does

This API retrieves the details of the User Occupation based of the UserID


#### Inputs



* {UserID}: The unique identifier for the user in the FashionWeather database


#### Outputs

Returns the UserID, User date of birth, and the user occupation.



* int UserID
* datetime DoB
* string UserOccupation

#### Sample Code
```
{
    var param = new SqlParameter("@UserID", UserID);
    var userOccupation = await _context.Users
        .FromSqlRaw("EXEC SeeOccupation @UserID", param)
        .ToListAsync();

    return userOccupation;
}
```

### TemperatureService (Emily Surface)


#### What It Does

This API retrieves the temperature for the day based on the WeatherID given


#### Inputs



* {WeatherID}: The unique identifier for the Weather in the FashionWeather database


#### Outputs

Returns the WeatherID, WeatherType, Temperature, and the Precipitation



* int WeatherID
* string WeatherType
* string Temperature
* string Precipitation

#### Sample Code
```
        [HttpGet("{WeatherId}")]
        public async Task<ActionResult<List<Weather>>> GetTemperature(int WeatherId)
        {
            var temperatures = await _temperature.GetTemperature(WeatherId);
            if (temperatures == null)
            {
                return NotFound();
            }
            return temperatures;
        }
```


### GetPriceService (Emily Mago)


#### What It Does

This API takes an input of ClothingID and returns the Clothing item and Price of all pieces under $20.00. This can be helpful in many ways, especially if there is a customer that is trying to find a sale or stick to a budget. This allows our website to give affordable options within our customer’s range, as we do not want to turn away anyone because of the price of an item.


#### Inputs



* {ClothingID}: Unique identifier for each piece of clothing


#### Outputs

Returns the ClothingID and Price



* int ClothingID
* money Price


### WeatherTypeService (Rylee Norman)


#### What it Does

This API takes an input of WeatherID and returns the Weather type (ex. Rainy, Snowy, etc.). This is another important service that will help us give the best recommendations to our customers for the day. This will allow us to include things like a raincoat, boots, or gloves that you may forget in the mornings while getting ready for your day. This API is from a new Stored Procedure added after the last assignment. The file for the new Stored Procedure is also in the repository.


#### Inputs



* {WeatherID}: Unique identifier for the Weather in the FashionWeather database


#### Outputs

Returns the WeatherID and WeatherType



* int WeatherID
* string WeatherType
