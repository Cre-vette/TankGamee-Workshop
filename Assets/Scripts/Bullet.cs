using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float timeRemaining = 2;
    void OnCollisionEnter(Collision collision)
    {
        // V�rifie si la collision est avec une cible
        if (collision.gameObject.CompareTag("Cible"))
        {
            // Trouve le ScoreManager dans la sc�ne
            ScoreManager scoreManager = Object.FindFirstObjectByType<ScoreManager>();

            // V�rifie si le ScoreManager a �t� trouv�
            if (scoreManager != null)
            {
                // Appelle la m�thode OnBulletHitTarget() du ScoreManager pour augmenter le score
                scoreManager.OnBulletHitTarget();
            }

            Destroy(gameObject); // D�truit la balle
        }
    }

    // M�thode appel�e � chaque frame
    void Update()
    {
        // R�duit le temps restant
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
