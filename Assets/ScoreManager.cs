using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;//for score display

public class ScoreManager : MonoBehaviour
{
    public int Score = 0;

    public TMP_Text Text;//for score display

    public void AddScore(int score = 1)
    {
        Score += score;

        if (Text != null)//Score counter
        {
            Text.text = Score.ToString();
        }
    }

}
