using System.Linq;
using UnityEditor;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacleObject;
    public Transform ground;

    public float distanceBetweenSpawn = 50f;

    private Transform playerTransform;

    private Vector3 previousPosition;

    public float spawnDistance = 50f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (previousPosition.z + distanceBetweenSpawn < playerTransform.position.z) spawnObstacles();
    }

    private void spawnObstacles()
    {
        previousPosition = playerTransform.position;

        float obstacleWidth = obstacleObject.transform.localScale.x;
        float groundWidth = ground.localScale.x;
        float maxLeftPosition = ground.position.x - (groundWidth / 2);
        float maxRightPosition = ground.position.x + (groundWidth / 2);

        int toSpawn = Random.Range(1, 4);
        Vector3[] spawnPositions = new Vector3[toSpawn];

        for (int i = 0; i < toSpawn; i++)
        {
            Vector3 potentialPosition;
            bool positionIsValid;

            do
            {
                positionIsValid = true;
                // 1. Generate a potential spawn position
                float randomX = Random.Range(maxLeftPosition + obstacleWidth / 2, maxRightPosition - obstacleWidth / 2);
                potentialPosition = playerTransform.position + playerTransform.forward * spawnDistance;
                potentialPosition.x = randomX;

                // 2. Check it against all previously placed obstacles in this batch
                for (int j = 0; j < i; j++)
                {
                    if (Mathf.Abs(potentialPosition.x - spawnPositions[j].x) < obstacleWidth)
                    {
                        positionIsValid = false;
                        break;
                    }
                }
            } while (!positionIsValid);

            // 3. Store the valid position
            spawnPositions[i] = potentialPosition;
        }

        // 4. Instantiate all the obstacles
        foreach (var pos in spawnPositions)
        {
            Instantiate(obstacleObject, pos, Quaternion.identity);
        }
    }
}
