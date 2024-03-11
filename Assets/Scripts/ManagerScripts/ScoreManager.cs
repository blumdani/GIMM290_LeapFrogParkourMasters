using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour, IGameManager
{
    public ManagerStatus status {get; private set;}

    private int player1Score = 0;
    private int player2Score = 0;
    private int player1HeldFood = 0;
    private int player2HeldFood = 0;  

    public void Startup() {
		Debug.Log("Score manager starting...");

		// any long-running startup tasks go here, and set status to 'Initializing' until those tasks are complete
		status = ManagerStatus.Started;
	}

    void Awake() {
        List<int> scores = new List<int>();
        scores.Add(player1Score);
        scores.Add(player2Score);
    }
    // Update is called once per frame
    public void ScoreUpdate(int playerNumber)
    {
        if(playerNumber == 1)
        {
            player1Score++;
        }
        else if(playerNumber == 2)
        {
            player2Score++;
        }
    }

    public int ViewScore(int playerNumber)
    {
        if(playerNumber == 1)
        {
            return player1Score;
        }
        else
        {
            return player2Score;
        }
    }

    public void ScoreReset() {
        player1Score = 0;
        player2Score = 0;
        player1HeldFood = 0;
        player2HeldFood = 0;
    }

    public void HeldFoodReset(int playerNumber) {
        if(playerNumber == 1)
        {
            player1HeldFood = 0;
        }
        else
        {
            player2HeldFood = 0;
        }
    }

    public int ViewHeldFood(int playerNumber)
    {
        if(playerNumber == 1)
        {
            return player1HeldFood;
        }
        else
        {
            return player2HeldFood;
        }
    }

    public void HeldFoodUpdate(int playerNumber)
    {
        if(playerNumber == 1)
        {
            player1HeldFood++;
        }
        else if(playerNumber == 2)
        {
            player2HeldFood++;
        }
    }
}