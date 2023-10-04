using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhub : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //transform.Translate(h * speed * Time.deltaTime, v * speed * Time.deltaTime, 0);
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        rb.velocity = dir * speed; 

    }

    private void OnTriggerEnter(Collider col)
    {
        AchievItem item = col.GetComponent<AchievItem>();

        if (item != null)
        {
            AchievementsControl.instance.SetAchiement(item, true);
        }
        if (col.CompareTag("chave"))
        {
            Destroy(col.gameObject);
        }


    }
}