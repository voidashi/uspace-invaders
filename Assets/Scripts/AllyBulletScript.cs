using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyBulletScript : MonoBehaviour
{
    private float speed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the bullet up
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }

    // Destroy the bullet when it leaves the screen
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
