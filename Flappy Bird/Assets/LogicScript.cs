using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void addScore(int addThis)
    {
        playerScore = playerScore + addThis;
        scoreText.text = playerScore.ToString();
    }
}
