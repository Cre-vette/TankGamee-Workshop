using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score { get; private set; }
    
    [SerializeField] TextMeshProUGUI scoreText;

    public void OnBulletHitTarget()
    {
        // Augmente le score lorsqu'une cible est touchée
        score += 1;

        // Met à jour l'affichage du score
        UpdateScoreUI();
    }

    // Méthode pour mettre à jour l'affichage du score
    void UpdateScoreUI()
    {
        scoreText.text = score.ToString() + "/10"; // Met à jour le texte du score

        // Vous pouvez ajouter ici une condition pour vérifier si le score a atteint 10 et déclencher une action en conséquence
        if (score >= 10)
        {
            // Par exemple, afficher un message de victoire ou exécuter une autre action
            Debug.Log("Vous avez atteint un score de 10!");
        }
    }




}
