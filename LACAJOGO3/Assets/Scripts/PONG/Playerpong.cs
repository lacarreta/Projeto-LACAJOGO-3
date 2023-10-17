using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerpong : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        float v = Input.GetAxis("Vertical");
        Vector3 dir = Vector3.up * v;
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
