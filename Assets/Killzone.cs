using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killzone : MonoBehaviour
{

    public GameObject KillAudio;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.gameObject.CompareTag("Player"))
            return;

        Destroy(col.gameObject);
        
        SceneManager.LoadScene("GameOver"); //when plane crashed, its game over and scene switch
        //dont have time implement delay before audio cuts off
    }
}
