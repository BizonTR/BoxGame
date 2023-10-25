using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    // Start is called before the first frame update
    private float topY;
    private float bottomY;
    public GameObject enemyObject;
    private float spawnControlTime;
    void Start()
    {
        topY = 4.5f;
        bottomY = -4.5f;

        spawnControlTime = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        spawnControlTime -= Time.deltaTime;

        if (spawnControlTime < 0f)
        {
            var randomNumber = Random.Range(0f, 3f);

            if (randomNumber > 1) 
            {
                var y = Random.Range(bottomY, topY);
                Instantiate(enemyObject, new Vector2(12.5f, y), Quaternion.identity);
                spawnControlTime = 0.5f;
            }
        }
    }
}
