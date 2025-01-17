using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    [SerializeField] float spawnRate = 1.0f;
    int range = 10;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnRate);
            Vector3 newPosition = new Vector3(transform.position.x + Random.Range(-range, range), transform.position.y, transform.position.z + Random.Range(-range, range));
            Instantiate(enemy, newPosition, transform.rotation);
        }
    }
}
