using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private GameObject[] enemys;
    [SerializeField] private GameObject player;

    private float speed = 5f;
    private float time = 1.0f;

    private float maxX = 5f;
    private float minX = -5f;
    private float maxZ = 15f;
    private float minZ = 0f;

    private void Update()
    {
        EnemyGeneration();
    }

    private void EnemyGeneration()
    {
        time -= Time.deltaTime;

        if (time <= 0.0f)
        {
            time = 1.0f;
            int number = Random.Range(0, enemys.Length);
            float spawnX = Random.Range(minX, maxX);
            float spawnZ = Random.Range(minZ, maxZ);

            GameObject newEnemy = Instantiate(enemys[number], new Vector3(spawnX, 0, spawnZ), Quaternion.identity);

            EnemyMove moveScript = newEnemy.GetComponent<EnemyMove>();
            if (moveScript != null && player != null)
            {
                moveScript.SetTarget(player.transform);
            }
        }
    }
}
