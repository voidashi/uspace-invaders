using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawnerScript : MonoBehaviour
{
    public GameObject alienPrefab;
    public float spawnRate = 1f;

    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(alienPrefab, transform.position, transform.rotation);
            timer = 0f;
        }
    }
}
