using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _ObstaclePrefabs; //the towers
    [SerializeField] private float _timer; //duration for the spawn to happen
    [SerializeField] private float _yClamp; //what will spawn

    private float _elapsedTime; //for tacking countdown

    // Update is called once per frame
    void Update()
    {
        _elapsedTime += Time.deltaTime; //elapsedTime will increment

        if(_elapsedTime > _timer) //when elapsedTime reached to timer value,
        {
            SpawnObject(); //object spawn

            _elapsedTime = 0f; //elapsedTime reset to 0
        }
    }

    private void SpawnObject()
    {
        float offsetY = UnityEngine.Random.Range(-_yClamp, _yClamp);

        Vector2 pos = new Vector2(this.transform.position.x, this.transform.position.y + offsetY);

        Instantiate(_ObstaclePrefabs, pos, Quaternion.identity, this.transform);
    }
}
