# VideoGameFinderDLC.API

Video Game Finder is a C# API to help find, sort, and rate a video game library. 

We sought to take some of the video game 'collecting' components of services such as Steam, and build a more user friendly, thinned, version that gives you the freedom to 
find and edit a video game library.  Each game can be detailed with genre, playable game systems, ratings, release date, ESRB rating, personal rating, price, and player count / multiplayer option. 

Our target audience are gamers of any experience level.  

Why did we build this?  All four members of the team are video game lovers and we thought it’d be fun to build something that includes one of our favorite hobbies.

--
## How it works: 
Video Game Finder API is fully equipped with CRUD that permits user to log in, then create, view, update, or delete a game, a game genre, a game system, and/or a personal user rating. 

IMPORTANT: 
To add data for game, game system, game genre and a unique user rating, you must add data in the following steps: 
1. Game System - If no game system exists, or the game system you want is not yet added, please start with CREATING one.  
2. Game Genre - If no game genre exists, or the gam egenre you want is not yet added, please add this after adding a game system. 
3. Game - GameSystemId and GameGenreId are required to create a game, and these are automatically created once the above steps have been taken. 
4. User Rating - GameId is required to create a user rating, a GameId is created when following the above step. 

WARNINGS: 
1. If you delete a Game Genre or Game System, any games tied to them will not be fully viewable or editable. 
2. If you delete a Game, your saved User Rating will be deleted permanently. 

--
## Structure and Development

Planning doc: https://docs.google.com/document/d/1bxPTlp6MCWlchDbpHXjZKuSNovbah1o0Dlo_paf3QMI/edit?usp=sharing

Table breakdown: https://docs.google.com/spreadsheets/d/11S0XnysUMjEelImNsa3yOtMunQRH_M3OutHNk1c9dG8/edit?usp=sharing

--
## The future of Video Game Finder: 
Upcoming features include: 
- Personal Library 
- Ability to add a friend and view their library 
- Leave a detailed review 
- A Top Rated list based off all users ratings 

--
## Credits: 
Video Game Finder was built by Austin's Boyz: 

Greg Gonzalez - Game Code / GitMaster 

Danny An - Game System Code

Charles Lucas - User Rating Code

Kraegan Graves - Game Genre Code / GitMaster 2 

