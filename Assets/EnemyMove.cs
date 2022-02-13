using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Vector3[] SpawnPosition;
    public int SpawnPoint;
    public Vector3 CurrentSpawnPoint;

    public GameObject Enemy;

    public bool _canSpawnEnemy = true;

    public float speed = 0.02f;

    void Update()
    {
        if(_canSpawnEnemy)
        {
            StartCoroutine(SpawnEnemy());
        }

        transform.position = (new Vector3(transform.position.x, transform.position.y, transform.position.z - speed));
    }

    IEnumerator SpawnEnemy()
    {
        _canSpawnEnemy = false;
        SpawnPoint = Random.Range(0, SpawnPosition.Length);
        CurrentSpawnPoint = SpawnPosition[SpawnPoint];

        Instantiate(Enemy, CurrentSpawnPoint, Quaternion.identity);

        Debug.Log(CurrentSpawnPoint.ToString());

        yield return new WaitForSeconds(Random.Range(1f, 3f));
        _canSpawnEnemy = true;
    }
}
