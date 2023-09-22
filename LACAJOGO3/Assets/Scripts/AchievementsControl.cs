using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Adicione esta linha se estiver usando UI Image

public class AchievementsControl : MonoBehaviour
{
    public static AchievementsControl instance;
    public bool[] achievements = { false, false, false, false, false };
    public GameObject achievementImage; // Referência ao GameObject da imagem do achievement

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        // Desative a imagem do achievement no início
        if (achievementImage != null)
        {
            achievementImage.SetActive(false);
        }
    }

    public void SetAchiement(AchievItem item, bool state)
    {
        achievements[item.id] = state;

        // Ative a imagem do achievement quando um achievement for coletado
        if (state && achievementImage != null)
        {
            achievementImage.SetActive(true);
        }
    }
}
