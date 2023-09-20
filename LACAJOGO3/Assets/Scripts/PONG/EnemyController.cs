using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyController : MonoBehaviour
{
    public Transform ball; // Referência para o transform da bola (arraste o GameObject da bola para este campo no Inspector)
    public float moveSpeed = 7f; // Velocidade de movimento do inimigo
    public float failProbability = 0.6f; // Probabilidade de falha (ajuste conforme necessário)

    private Vector3 originalPosition; // Posição original do inimigo

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        if (ball != null)
        {
            if (Random.value < failProbability)
            {
                // Simule uma falha aleatória
                Vector3 randomOffset = new Vector3(0f, Random.Range(-1f, 1f), 0f);
                transform.position = originalPosition + randomOffset;
            }
            else
            {
                // Calcula a direção para a bola apenas ao longo do eixo Y
                float directionY = ball.position.y - transform.position.y;

                // Move o inimigo na direção vertical da bola
                transform.Translate(Vector3.up * directionY * moveSpeed * Time.deltaTime);
            }
        }
    }
}
