using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class finalscore : MonoBehaviour
{
    public TMP_Text Text;

    // Update is called once per frame
    void Update() 
    {
        if (Text != null)// building pass counter
        {
            Text.text = "Buildings avoided: " + ScoreManager.FinalScore.ToString();
        }
    }
}
