using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguishCandles : MonoBehaviour
{
    public GameObject unlit_skull_prefab;

    void Update()
    {
        // If lit skull has fallen over
        if (transform.rotation.x < -0.5 || transform.rotation.x > 0.5 || transform.rotation.z < -0.5 || transform.rotation.z > 0.5)
        {
            // Replace with unlit version
            Instantiate(unlit_skull_prefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}