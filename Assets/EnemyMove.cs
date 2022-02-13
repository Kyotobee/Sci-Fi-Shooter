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

    void Update()
    {
        if(_canSpawnEnemy)
        {
            StartCoroutine(SpawnEnemy());
        }
    }

    IEnumerator SpawnEnemy()
    {
        _canSpawnEnemy = false;
        SpawnPoint = Random.Range(0, SpawnPosition.Length);
        CurrentSpawnPoint = SpawnPosition[SpawnPoint];

        Instantiate(Enemy, CurrentSpawnPoint, Quaternion.identity);
        Debug.Log(CurrentSpawnPoint.ToString());

        yield return new WaitForSeconds(Random.Range(2f, 5f));
        _canSpawnEnemy = true;
    }
}
