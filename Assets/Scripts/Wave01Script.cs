using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave01Script : MonoBehaviour
{
    public LogicScript logic;
    public float speed = 1f;
    public float downMovement = 1f;

    private int direction = 1; // 1 = right, -1 = left

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
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
        if (transform.position.x > 2)
        {
            direction = -1;
            transform.Translate(Vector3.down * downMovement);
            transform.Translate(Vector3.left * Time.deltaTime * 1); // Move a bit to the left to avoid getting stuck
        }
        else if (transform.position.x < -2) // If hit the left edge, change direction to right
        {
            direction = 1;
            transform.Translate(Vector3.down * downMovement);
            transform.Translate(Vector3.right * Time.deltaTime * 1); // Move a bit to the right to avoid getting stuck 
        }

        // If hit the bottom, game over
        if (transform.position.y <= -4)
        {
            logic.GameOver();
        }
    }
}
