using System;
using UnityEngine;

public class PipeSpawnerComponent : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float secondsToSpawn = 2f;
    
    private float spawnTimer = 0f;

    private void Awake()
    {
        spawnTimer = 0;
    }

    private void Update()
    {
        if (!GameStateManager.IsInGame())
            return;
        
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= secondsToSpawn)
        {
            Instantiate(pipePrefab, transform.position, transform.rotation);
            spawnTimer = 0;
        }
    }
}
