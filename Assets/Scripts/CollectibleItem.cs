using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectibleItem : MonoBehaviour {
    [SerializeField] string itemName;
    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;
    public TextMeshProUGUI playerWinsText;

    void Start()
    {
        Debug.Log("Setting text references");
        player1ScoreText = GameObject.FindWithTag("player1HeldFood").GetComponent<TextMeshProUGUI>();
        player2ScoreText = GameObject.FindWithTag("player2HeldFood").GetComponent<TextMeshProUGUI>();
        playerWinsText = GameObject.FindWithTag("playerWins").GetComponent<TextMeshProUGUI>();
    }

    void OnTriggerEnter(Collider other) {
        PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
        //Vector3 newSize = other.gameObject.transform.localScale;

        if(other.gameObject.name == "Player1")
        {
            Managers.Score.HeldFoodUpdate(1);
            player1ScoreText.text = "Food Held: " + Managers.Score.ViewHeldFood(1);
            Destroy(this.gameObject);
            playerController.speed -= 6f;
            playerController.jumpForce -= 6f;
            //newSize.x += 2;
            //other.gameObject.transform.localScale = newSize;
        }
        else if(other.gameObject.name == "Player2")
        {
            Managers.Score.HeldFoodUpdate(2);
            player2ScoreText.text = "Food Held: " + Managers.Score.ViewHeldFood(2);
            Destroy(this.gameObject);
            playerController.speed -= 6f;
            playerController.jumpForce -= 6f;
            //newSize.x += 2;
            //other.gameObject.transform.localScale = newSize;
        }
        Managers.Inventory.AddItem(itemName);
    }
}
