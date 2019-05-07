# MVC Movie

**Author**: Arthur Allen

**Version**: 1.0.0 (increment the patch/fix version number up if you make more commits past your first submission)

## Overview
<!-- Provide a high level overview of what this application is and why you are building it, beyond the fact that it's an assignment for a Code Fellows 401 class. (i.e. What's your problem domain?) -->
Excercise in creating a Model View Controler project using scaffolding

## Getting Started
<!-- What are the steps that a user must take in order to build this app on their own machine and get it running? -->
Visual Studio 2017.
.Net Core
Get started with ASP.NET Core MVC and Visual Studio: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?tabs=aspnetcore2x

## Example
<!-- Show them what looks like and how to use the application.  -->
The home page is still a generic .Net Core splash screen with a carosel.  The Movie App option on the black bar on the upper left leads to the special functionality of this particular app.  There you will find a list of movies if they are already populated in the database.  You also have the option to add new titles, edit enteries, and delete them.

## Architecture
<!-- Provide a detailed description of the application design. What technologies (languages, libraries, etc) you're using, and any other relevant design information. -->
Scaffolded Model View Controller archetecture, using C#, .Net Core and Razor Pages.

## Change Log
<!-- Use this are to document the iterative changes made to your application as each feature is successfully implemented. Use time stamps. Here's an example:

01-01-2001 4:59pm - Added functionality to add and delete some things. -->
04-06-2018 9:00pm - Project built out almost per the tutorial.  Ratings don't get seeded into the database, and there is no rating option in the edit form, though you can create a rating when you make a new title.  For that matter, clicking "Save changes" in edit does nothing.  You stay on the same screen, and the changes are not saved.  Need to add CSS and other persionalized details.
04-06-2018 11:34am - Promised help in formating has never come.  I am pushing up and turning in what I've got
04-15-2018 5:14pm - I came back to this project to get a feel for front-end forms interacting with databases to be able to add them into my Consume the API project.  Along the way, I finally added Bootstrap formatting to the table, which was half of the battle for more points.  I also fixed the Ratings Regex again, this time so it could accept single-letter ratings such as G and R.  I then accidentially deleted the remote database in Azure, so I had to go back to the local database.  Next I need to improve the home page by taking away the carosel and personalizing it.  Pushing up now so I have a fallback environment.
04-15-2018 6:38pm - Admitedly minimal personalization of the home page, but it is the one rare success today. 