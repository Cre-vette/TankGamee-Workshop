using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{

    private ScoreManager scoreManager; // R�f�rence au gestionnaire de score
    public int maxScore = 2; // Score maximum pour la victoire
    public GameObject GameVictory; // Menu de victoire � activer

    void Start()
    {
        // Trouve le ScoreManager dans la sc�ne
        scoreManager = Object.FindFirstObjectByType<ScoreManager>();

        // V�rifie si le ScoreManager a �t� trouv�
        if (scoreManager == null)
        {
            Debug.LogError("Le ScoreManager n'a pas �t� trouv� dans la sc�ne.");
        }
    }
    void Update()
    {
        // V�rifie si le score actuel est �gal ou sup�rieur au score maximum
        if (scoreManager != null && scoreManager.score >= maxScore)
        {
            // Active le menu de victoire
            GameVictory.SetActive(true);
        }
    }
}
