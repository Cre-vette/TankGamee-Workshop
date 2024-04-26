using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{

    private ScoreManager scoreManager; // Référence au gestionnaire de score
    public int maxScore = 2; // Score maximum pour la victoire
    public GameObject GameVictory; // Menu de victoire à activer

    void Start()
    {
        // Trouve le ScoreManager dans la scène
        scoreManager = Object.FindFirstObjectByType<ScoreManager>();

        // Vérifie si le ScoreManager a été trouvé
        if (scoreManager == null)
        {
            Debug.LogError("Le ScoreManager n'a pas été trouvé dans la scène.");
        }
    }
    void Update()
    {
        // Vérifie si le score actuel est égal ou supérieur au score maximum
        if (scoreManager != null && scoreManager.score >= maxScore)
        {
            // Active le menu de victoire
            GameVictory.SetActive(true);
        }
    }
}
