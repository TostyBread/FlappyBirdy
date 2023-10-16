using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBox : MonoBehaviour
{
    private ScoreManager _scoreManager;
    public GameObject ScoreAudio;

    // Start is called before the first frame update
    void Start()
    {
        _scoreManager = FindObjectOfType<ScoreManager>(); //FindObjectOfType is expensive, mostly used in Start
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (!col.gameObject.CompareTag("Player"))
            return;

        if (_scoreManager == null)
            return;
            _scoreManager.AddScore();
        GameObject.Instantiate(ScoreAudio, transform.position, Quaternion.identity);
    }
}
