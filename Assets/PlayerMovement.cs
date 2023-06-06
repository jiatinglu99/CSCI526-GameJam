using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private uint direction = 0; // 0 = up, 1 = right, 2 = down, 3 = left
    private bool isHorizontal = false;
    private float moveThreshold = 0.5f;
    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal"); // -1, 0, 1
        float verticalInput = Input.GetAxisRaw("Vertical"); // -1, 0, 1
        if (horizontalInput > moveThreshold) {
            direction = 1;
            isHorizontal = true;
            // move right
            rb.velocity = new Vector2(5, 0);
        } else if (horizontalInput < -moveThreshold) {
            direction = 3;
            isHorizontal = true;
            // move left
            rb.velocity = new Vector2(-5, 0);
        } else if (verticalInput > moveThreshold) {
            direction = 0;
            isHorizontal = false;
            // move up
            rb.velocity = new Vector2(0, 5);
        } else if (verticalInput < -moveThreshold) {
            direction = 2;
            isHorizontal = false;
            // move down
            rb.velocity = new Vector2(0, -5);
        }
        else {
            rb.velocity = new Vector2(0, 0);
        }
        // Debug.Log(direction);
    }
}
