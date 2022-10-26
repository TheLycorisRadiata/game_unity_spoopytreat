using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jump_force = 5f;
    public bool is_on_ground = false;
    private float horizontal_input;
    private float forward_input;
    private Rigidbody player_rb;

    void Start()
    {
        player_rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        /*
            DIRECTION INPUT
            - Arrow keys
            - "Use physical keys" is enabled, so it's not necessarily WASD but whatever equivalent
            - Console controller
        */

        // Get player directional input
        horizontal_input = Input.GetAxis("Horizontal");
        forward_input = Input.GetAxis("Vertical");

        // Move the player in 4 directions
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontal_input);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forward_input);

        // Player jumps
        if (Input.GetKeyDown(KeyCode.Space) && is_on_ground)
        {
            player_rb.AddForce(Vector3.up * jump_force, ForceMode.Impulse);
            is_on_ground = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            is_on_ground = true;
    }
}