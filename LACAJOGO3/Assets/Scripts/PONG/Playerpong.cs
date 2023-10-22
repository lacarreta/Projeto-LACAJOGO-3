using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerpong : MonoBehaviour
{
    public float speed;

    void Start()
    {

    }

    void Update()
    {
<<<<<<< HEAD
        
        float v = Input.GetAxis("Vertical");
        Vector3 dir = Vector3.up * v;
        rb.velocity = dir * speed; 

=======
        float v = Input.GetAxis("Vertical");
        transform.Translate(0, v * speed * Time.deltaTime, 0);
>>>>>>> parent of 2810b489 (maze)
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
