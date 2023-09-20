using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercrossing : MonoBehaviour
{
    public float moveSpeed = 5f; 
    private Vector3 targetPosition;

    private void Start()
    {
        targetPosition = transform.position; 
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (Mathf.Abs(horizontalInput) > 0.1f || Mathf.Abs(verticalInput) > 0.1f)
        {
            
            targetPosition = transform.position + new Vector3(horizontalInput, verticalInput, 0f);
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }
}
