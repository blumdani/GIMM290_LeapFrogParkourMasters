using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableRestartButton : MonoBehaviour
{
    public Button restartButton;
    
    void Update()
    {
        if(DepositFood.hasEnded)
        {
            restartButton.gameObject.SetActive(true);
        }
        else
        {
            restartButton.gameObject.SetActive(false);
        }
    }
}
