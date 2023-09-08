using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhub : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(h * speed * Time.deltaTime, v * speed * Time.deltaTime, 0);
    }
}