using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayershipScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public LogicScript logic;
    public int health = 3;

    private bool isShooting = false;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move the ship left and right
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5);
        }

        // // Move the ship left and right in blocky steps
        // if (Input.GetKeyDown(KeyCode.LeftArrow))
        // {
        //     transform.Translate(Vector3.left * 1);
        // }
        // if (Input.GetKeyDown(KeyCode.RightArrow))
        // {
        //     transform.Translate(Vector3.right * 1);
        // }

        // // Shoot a bullet
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        // }

        // Shoot a bullet
        if (Input.GetKey(KeyCode.Space) && !isShooting)
        {
            StartCoroutine(Shoot());
        }
    }

    // Destroy the ship if it collides with an enemy bullet
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Collide on layer 8 (EnemyBullet)
        if (collision.gameObject.layer == 8)
        {
            health--;
            Destroy(collision.gameObject);

            // If health is 0, destroy the ship and call GameOver()
            if (health <= 0)
            {
                Destroy(gameObject);
                logic.GameOver();
            }
        }
    }

    // Shoot a bullet
    private IEnumerator Shoot()
    {
        isShooting = true;
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        isShooting = false;
    }
}
