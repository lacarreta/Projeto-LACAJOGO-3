using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievItem : MonoBehaviour
{
    public int id;
    public AudioClip pickupSound; // Adicione a referência ao seu som aqui
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = pickupSound;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Reproduzir o som quando o GameObject for coletado
            audioSource.Play();

            // Execute qualquer outra lógica relacionada à coleta aqui

            // Por exemplo, desativar o GameObject
            gameObject.SetActive(false);
        }
    }
}
