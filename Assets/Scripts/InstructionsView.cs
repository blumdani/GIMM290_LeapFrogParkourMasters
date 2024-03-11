using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InstructionsView : MonoBehaviour
{
    private bool isShowing = false;
    public TextMeshProUGUI instructionsText;

    public void OnButtonClick()
    {
        if(isShowing == false)
        {
            //Show instructions
            isShowing = true;
            instructionsText.text = "Food will randomly spawn across the map. Gather more food than your opponent! \n\n The first squirrel to store 7 Winter rations wins. \n\n Player 1: WAD to move, S to jump \n Player 2: IJL to move, K to jump \n\n Careful! The more food you are holding, the slower and heavier you will be. Store your food in the correct colored tree to drop that food off. Bank food to score points and manage your speed and jumping ability. \n\n\n Good luck!";
        }
        else if(isShowing == true)
        {
            //Hide instructions
            isShowing = false;
            instructionsText.text = "The squirrel awoke groggily; he yawned and stretched, marking the end of a satisfying slumber. However, his peaceful bliss quickly turned to panic as his senses returned to him. He looked over at his alarm clock; he had set it for 8PM, not AM!! \n\n He darted out of bed and ran into the forest. Winter was coming soon, and he needed to stock up on food. All the normal spots had been picked clean, as other squirrels nestled into their homes, their food storage filled. His worry grew with every empty area he found in his frantic search. \n\n Finally, he came to a clearing that was ripe for scavenging. Unfortunately, he was not the only one still looking for Winter sustenance...";
        }
    }
}
