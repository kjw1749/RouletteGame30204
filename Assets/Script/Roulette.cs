using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulette : MonoBehaviour
{
    float rotSpeed = 0;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10.0f;
        }
        transform.Rotate(0, 0, this.rotSpeed);

        if (Input.GetMouseButton(1))
        {
            this.rotSpeed = 0f;

        }
        this.rotSpeed *= 0.99f;
    }
}
