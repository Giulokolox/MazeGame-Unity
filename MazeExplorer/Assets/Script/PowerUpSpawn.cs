using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawn : MonoBehaviour
{
    public GameObject powerUpPrefab;
    public int maxPowerUps = 5;
    public float spawnRange = 3f;

    private void Start()
    {
        SpawnPowerUps();
    }

    private void SpawnPowerUps()
    {
        for (int i = 0; i < maxPowerUps; i++)
        {
            Vector3 spawnPosition = GetRandomSpawnPosition();
            Collider[] colliders = Physics.OverlapSphere(spawnPosition, 1f);

            // Verifica se ci sono collisioni con altri collider diversi
            if (colliders.Length == 0)
            {
                Instantiate(powerUpPrefab, spawnPosition, Quaternion.identity);
            }
            else
            {
                // Riprova lo spawn fino a quando non viene trovata una posizione valida
                i--;
            }
        }
    }

    private Vector3 GetRandomSpawnPosition()
    {
        Vector2 randomCircle = Random.insideUnitCircle * spawnRange;
        Vector3 spawnPosition = transform.position + new Vector3(randomCircle.x, 0f, randomCircle.y);
        return spawnPosition;
    }
}