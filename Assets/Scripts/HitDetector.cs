using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitDetector : MonoBehaviour
{
    /*public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;
    public TextMeshProUGUI playerWinsText;

    private GameObject player1;
    private GameObject player2;
    private bool isOver = false;
    private static int player1Score = 0;
    private static int player2Score = 0;

    private float scoreCooldown = 1.0f;
    private static float lastScoreTimePlayer1 = -1.0f;
    private static float lastScoreTimePlayer2 = -1.0f;

    public static bool canJump = true;

    void Start()
    {
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != gameObject && !isOver && (other.gameObject == player1 || other.gameObject == player2))
        {
            if (gameObject.transform.position.y > other.gameObject.transform.position.y && canJump)    
            {
                Debug.Log(gameObject.name + " jumped over " + other.gameObject.name + "!");
                isOver = true;

                if (other.gameObject == player1 && Time.time - lastScoreTimePlayer2 > scoreCooldown)
                {
                    Managers.Score.ScoreUpdate(2);
                    player2ScoreText.text = "Player 2: " + Managers.Score.ViewScore(2);
                    lastScoreTimePlayer2 = Time.time;
                }
                else if(other.gameObject == player2 && Time.time - lastScoreTimePlayer1 > scoreCooldown)
                {
                    Managers.Score.ScoreUpdate(1);
                    player1ScoreText.text = "Player 1: " + Managers.Score.ViewScore(1);
                    lastScoreTimePlayer1 = Time.time;
                }

                if(Managers.Score.ViewScore(1) >= 5)
                {  
                    player1ScoreText.text = "";
                    player2ScoreText.text = "";
                    playerWinsText.text = "Player 1 Wins!!";
                    StartCoroutine(FlashText());
                }
                else if(Managers.Score.ViewScore(2) >= 5)
                {
                    player2ScoreText.text = "";
                    player1ScoreText.text = "";
                    playerWinsText.text = "Player 2 Wins!!";
                    StartCoroutine(FlashText());
                }
            }
        }
    }
        
    IEnumerator FlashText()
    {
        canJump = false;
        int textFlashes = 0;
        while(textFlashes <= 10)
        {
            playerWinsText.enabled = !playerWinsText.enabled;
            yield return new WaitForSeconds(0.6f);
            textFlashes++;
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        canJump = true;
        Managers.Score.ScoreReset();
    } 
    

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject != gameObject)
        {
            isOver = false;
        }
    }*/
}