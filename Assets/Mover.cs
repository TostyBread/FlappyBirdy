using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public float MoveSpeed = 0.7f;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -14)
            Destroy(gameObject);

        Vector2 targetMovePosition = transform.position;
        targetMovePosition.x -= MoveSpeed * Time.deltaTime;

        transform.position = targetMovePosition;

        
    }
}
