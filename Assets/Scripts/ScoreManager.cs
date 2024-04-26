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
        // Augmente le score lorsqu'une cible est touch�e
        score += 1;

        // Met � jour l'affichage du score
        UpdateScoreUI();
    }

    // M�thode pour mettre � jour l'affichage du score
    void UpdateScoreUI()
    {
        scoreText.text = score.ToString() + "/10"; // Met � jour le texte du score

        // Vous pouvez ajouter ici une condition pour v�rifier si le score a atteint 10 et d�clencher une action en cons�quence
        if (score >= 10)
        {
            // Par exemple, afficher un message de victoire ou ex�cuter une autre action
            Debug.Log("Vous avez atteint un score de 10!");
        }
    }




}
