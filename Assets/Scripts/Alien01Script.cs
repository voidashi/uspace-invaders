using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien01Script : MonoBehaviour
{
    public LogicScript logic;
    public float speed = 2f;

    private Animator anim;
    private int direction = 1; // 1 = right, -1 = left

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        anim = GetComponent<Animator>();
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

        // If hit the edge, change direction and move down
        if (transform.position.x > 8)
        {
            direction = -1;
            transform.Translate(Vector3.down * 1);
            transform.Translate(Vector3.left * Time.deltaTime * 1); // Move a bit to the left to avoid getting stuck
        }
        else if (transform.position.x < -8) // If hit the left edge, change direction to right
        {
            direction = 1;
            transform.Translate(Vector3.down * 1);
            transform.Translate(Vector3.right * Time.deltaTime * 1); // Move a bit to the right to avoid getting stuck 
        }
    }

    // Destroy the alien if it collides with a bullet
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 7) // If the bullet hits the alien
        {
            anim.Play("Explosion");
            Destroy(gameObject, 0.3f);
            Destroy(collision.gameObject); // Destroy the bullet
            logic.IncreaseScore(1);
        }
    }
}
