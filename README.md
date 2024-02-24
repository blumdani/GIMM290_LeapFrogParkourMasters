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
