using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DepositFood : MonoBehaviour
{
    public TextMeshProUGUI player1Score;
    public TextMeshProUGUI player2Score;
    public TextMeshProUGUI playerWinsText;
    public TextMeshProUGUI player1HeldFood;
    public TextMeshProUGUI player2HeldFood;
    public static bool hasEnded = false;

    void Start()
    {
        player1Score = GameObject.FindWithTag("player1Score").GetComponent<TextMeshProUGUI>();
        player2Score = GameObject.FindWithTag("player2Score").GetComponent<TextMeshProUGUI>();
        playerWinsText = GameObject.FindWithTag("playerWins").GetComponent<TextMeshProUGUI>();
        player1HeldFood = GameObject.FindWithTag("player1HeldFood").GetComponent<TextMeshProUGUI>();
        player2HeldFood = GameObject.FindWithTag("player2HeldFood").GetComponent<TextMeshProUGUI>();
    }

    void OnCollisionEnter(Collision other)
    {
        PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
        //Vector3 newSize = other.gameObject.transform.localScale;

        if(other.gameObject.name == "Player1" && this.gameObject.name == "Player1_Tree" && Managers.Score.ViewHeldFood(1) > 0)
        {

            player1HeldFood.text = "Food Held: 0";
            for(int i = 0; i < Managers.Score.ViewHeldFood(1); i++)
            {
                Managers.Score.ScoreUpdate(1);
            }
            Managers.Score.HeldFoodReset(1);
            player1Score.text = "Player 1: " + Managers.Score.ViewScore(1);
            playerController.speed = 45f;
            playerController.jumpForce = 65f;
            //newSize.x = 5;
            //other.gameObject.transform.localScale = newSize;
            
            if(Managers.Score.ViewScore(1) >= 7)
            {  
                player1Score.text = "";
                player2Score.text = "";
                player1HeldFood.text = "";
                player2HeldFood.text = "";
                playerWinsText.text = "Player 1 Wins!!";
                hasEnded = true;
                Managers.Score.ScoreReset();
            }
        }
        if(other.gameObject.name == "Player2" && this.gameObject.name == "Player2_Tree" && Managers.Score.ViewHeldFood(2) > 0)
        {

            player2HeldFood.text = "Food Held: 0";
            for(int i = 0; i < Managers.Score.ViewHeldFood(2); i++)
            {
                Managers.Score.ScoreUpdate(2);
            }
            Managers.Score.HeldFoodReset(2);
            player2Score.text = "Player 2: " + Managers.Score.ViewScore(2);
            playerController.speed = 45f;
            playerController.jumpForce = 65f;
            //newSize.x = 5;
            //other.gameObject.transform.localScale = newSize;
            
            if(Managers.Score.ViewScore(2) >= 7)
            {  
                player1Score.text = "";
                player2Score.text = "";
                player1HeldFood.text = "";
                player2HeldFood.text = "";
                playerWinsText.text = "Player 2 Wins!!";
                hasEnded = true;
                Managers.Score.ScoreReset();
            }
        }
    }
}
