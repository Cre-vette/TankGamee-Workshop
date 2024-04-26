using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float timeRemaining = 2;
    void OnCollisionEnter(Collision collision)
    {
        // Vérifie si la collision est avec une cible
        if (collision.gameObject.CompareTag("Cible"))
        {
            // Trouve le ScoreManager dans la scène
            ScoreManager scoreManager = Object.FindFirstObjectByType<ScoreManager>();

            // Vérifie si le ScoreManager a été trouvé
            if (scoreManager != null)
            {
                // Appelle la méthode OnBulletHitTarget() du ScoreManager pour augmenter le score
                scoreManager.OnBulletHitTarget();
            }

            Destroy(gameObject); // Détruit la balle
        }
    }

    // Méthode appelée à chaque frame
    void Update()
    {
        // Réduit le temps restant
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            Object.Destroy(this.gameObject);
        }
    }
}
