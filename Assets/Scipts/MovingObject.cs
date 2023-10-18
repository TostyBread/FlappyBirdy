using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] private float _MoveSpeed; //Speed of the tower
    [SerializeField] private float _xBound = -11; //Xaxis limit for tower

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= Vector3.right * _MoveSpeed * Time.deltaTime;

        if (transform.position.x <= _xBound) //when tower moved out of view and triggers an Xaxis
        {
            Destroy(gameObject);
        }
    }
}
