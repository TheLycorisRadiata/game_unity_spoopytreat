using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Movement
    public float directional_speed;
    public float rotate_speed;
    public float jump_force;
    public bool is_on_ground;

    // Items
    public int nbr_candies = 0;

    void Start()
    {
        directional_speed = 6f;
        rotate_speed = directional_speed / 2 * directional_speed * directional_speed;
        jump_force = 20f;
        is_on_ground = false;
    }
}
