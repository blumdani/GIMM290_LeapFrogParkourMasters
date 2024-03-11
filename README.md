Daniel Blumberg
GIMM 290
2/18/24

Unity 5 Assignment - Leap Frog Parkour Masters

Aside from the core instructions, there were a few bugfixes and alterations I wanted to make to the core gameplay. After those tweaks, the changes I made were:
1. I wanted the character to jump high enough to cleanly jump over the other player, but not be super floaty. I decided I needed a large jumpforce but also a lot of gravity in order to jump high but come back down quickly enough.
I adjusted the overall gravity in Edit -> Project Settings -> Physics to -100. Then adjusted my jumpForce variables on each character to be 130. I also made the walls transparent so the play field is easier to see.

2. I wanted to add a proper goal to the game; I decided that the first player to jump over the other character wins.
I added a basic UI to visually keep track of player scores. The first player that scores 10 points wins. This made a clear objective that would complete the game.

3. I decided 10 was too high, because the characters were small enough that it was difficult to jump over someone. Rather than make the characters bigger, I liked keeping the challenge of hitting that small moving target.
I lowered the score counter to 5, and added higher platforms that the players could use to get an advantage over each other. Finding the height advantage at the correct time and being able to hit a smaller moving target both added
skill elements to the gameplay. In this step, I also made it so that the scene and scores would reset after about 6 seconds, meaning the players could play another round if they wanted to.

I liked keeping the constraint of having no back movement; I think it forces the characters to be more intentional with their movements. Along with this CONSTRAINT, GOALS and SKILL/CHALLENGE are the main game design elements I
attempted to incorporate.


UNITY ASSIGNMENT 6 UPDATES - 2/24/24:
I already covered most of this assignment in Unity Assignment 5, but I made a few minor changes (I scaled the canvas to screen size and used the rect transform to anchor the scores. I also changed the flashing text so that it flashes in one spot in the middle of the screen instead of replacing the player score text fields.).
I kept my TextMeshPro objects because these are the preferred objects to use over the legacy Text objects outlined in the tutorial. I also made some other differences to my preferences, such as moving the Player Wins text to a spot not "exactly" in the middle of the screen, but where I found it aesthetically pleasing.

UNITY ASSIGNMENT 7 UPDATES - 3/3/24:
The changes from the Unity 7 assignment have been made. The RelativeMovement script was difficult to incorporate because I made significant changes to my controller script, so I wound up adding the small RelativeMovement script changes to my existing script for collider pushes. 

I added the managers, and included my own ScoreManager that managed holding, updating, resetting, and viewing scores. I implemented this into my HitDetector script and removed the existing score management in HitDetector.

I added a Collectible: right now it is a placeholder that I'm referring to as "Health" in the Debug Console, but it has been implemented as a proof of concept. I've also adjusted the CollectibleItem script to only respond to collisions from one of the players (rather than any collision; I noticed a box could also trigger this collision).

I also made some bugfixes around the way rotation was handled in my previous movement scripts: the movements are a lot more fluid now.


UNITY ASSIGNMENT 8 UPDATES - 3/10/24:
For this assignment, I changed the goal of the game. I leaned into the idea of collectibles, and wanted a race between two players to gather collectibles as quickly as possible. I added an intro scene with story and instructions to help give the game some context and a backstory. I also (slightly) themed the level to reflect this new backstory. 

The new goal is to hoard food in a forest before your opponent can. I focused on making this fairly skill-based; the player must be able to get to food quicker than their opponent, and also know when to go for another piece of food and when to store food. Food randomly spawns on the map, so there is also some chance involved. Feasibly, one player could have a much easier time if the food spawned in certain spots favorable to that player.

I also made a few general updates, including handling a few minor bug fixes. I added a restart button so that players could play multiple rounds, if desired.

If I'd had more time to work on this, I think it would have been fun to come up with some kind of way for players to attack each other and steal unbanked food. This might be something to consider in future versions of the game.
