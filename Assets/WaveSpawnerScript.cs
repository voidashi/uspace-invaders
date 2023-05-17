using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawnerScript : MonoBehaviour
{
    public float speed = 1f;

    private int direction = 1; // 1 = right, -1 = left
    private int edgeCount = 0; // Count how many times waves alien hit the edge

    public GameObject wave01Prefab;
    public GameObject wave02Prefab;
    public GameObject wave03Prefab;
    public GameObject wave04Prefab;
    public GameObject wave05Prefab;
    private List<GameObject> waves = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        waves.Add(wave01Prefab);
        waves.Add(wave02Prefab);
        waves.Add(wave03Prefab);
        waves.Add(wave04Prefab);
        waves.Add(wave05Prefab);
    }

    // Update is called once per frame
    void Update()
    {
        // Move the alien left and right
        if (direction == 1)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        else if (direction == -1)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        // If hit the edge, change direction and sum edgeCount
        if (transform.position.x > 2)
        {
            direction = -1;
            transform.Translate(Vector3.left * Time.deltaTime * 1); // Move a bit to the left to avoid getting stuck
            edgeCount++;
        }
        else if (transform.position.x < -2) // If hit the left edge, change direction to right
        {
            direction = 1;
            transform.Translate(Vector3.right * Time.deltaTime * 1); // Move a bit to the right to avoid getting stuck 
            edgeCount++;
        }

        // When hit the edge 3 times, spawn a new wave
        if (edgeCount == 4)
        {
            SpawnWave();
            edgeCount = 0;
        }
    }

    private void SpawnWave()
    {
        // Randomly select a wave to spawn
        int randomIndex = Random.Range(0, waves.Count);
        GameObject wave = waves[randomIndex];

        // Spawn the wave at y = 4
        Instantiate(wave, new Vector3(-2, 4, 0), transform.rotation);
        Debug.Log("Spawned wave " + randomIndex);
    }
}
