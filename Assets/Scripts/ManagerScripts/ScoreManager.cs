using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour, IGameManager
{
    public ManagerStatus status {get; private set;}

    private int player1Score = 0;
    private int player2Score = 1;   

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
    }
}