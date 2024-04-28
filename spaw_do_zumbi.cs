using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaw_do_zumbi : MonoBehaviour
{
    public GameObject zumbi; // Prefab do objeto a ser spawnado
    public Vector3 spawnAreaSize = new Vector3(10f, 0f, 10f); // Tamanho da área de spawn
    public int maxSpawnCount = 10; // Número máximo de objetos a serem spawnados
    public float spawnInterval = 2f; // Intervalo entre spawns

    private float lastSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
         lastSpawnTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
         // Verifica se é hora de spawnar um novo objeto
        if (Time.time - lastSpawnTime >= spawnInterval && transform.childCount < maxSpawnCount)
        {
            SpawnObject();
            lastSpawnTime = Time.time;
        }
    }

    private void SpawnObject()
    {
        Vector3 randomSpawnPosition = transform.position + new Vector3(
            Random.Range(-spawnAreaSize.x / 2f, spawnAreaSize.x / 2f),
            0f,
            Random.Range(-spawnAreaSize.z / 2f, spawnAreaSize.z / 2f)
        );

        Instantiate(zumbi, randomSpawnPosition, Quaternion.identity, transform);
    }

    

    }
