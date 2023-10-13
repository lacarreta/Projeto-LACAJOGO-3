using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnCollision : MonoBehaviour
{
    public string sceneName = "02 CA";
    public float respawnX = 0.0f;
    public float respawnY = 0.0f;
    public float respawnZ = 0.0f;

    // Use uma variável booleana para controlar se o jogador já foi reposicionado.
    private bool hasRespawned = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!hasRespawned)
            {
                
                SceneManager.LoadScene(sceneName);

                // Posicione o jogador nas coordenadas especificadas.
                Vector3 respawnPosition = new Vector3(respawnX, respawnY, respawnZ);
                collision.transform.position = respawnPosition;

                // Marque o jogador como reposicionado.
                hasRespawned = true;
            }
        }
    }
}
