using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercrossing : MonoBehaviour

{
    public float speed = 6.0f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical") + 0.9f;
        Vector3 dir = new Vector3(x, 0, y) * Time.deltaTime * speed;
        transform.Translate(dir);
    }
}