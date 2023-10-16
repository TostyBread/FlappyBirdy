using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;//for score display

public class ScoreManager : MonoBehaviour
{
    public int Score = 0;
    public static int FinalScore;

    public TMP_Text Text;//for score display

    void Start()
    {
        FinalScore = 0; //Everytime a new game starts, The final score be cleared to avoid storing previous values
    }

    public void AddScore(int score = 1) // will add score by 1
    {
        Score += score;
        FinalScore += score;

        if (Text != null)//Score counter
        {
            Text.text = Score.ToString();
        }
    }

}
