using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Punteggi per c1 e c2
    public int scoreC1 = 0;
    public int scoreC2 = 0;

    // Rende questo GameObject persistente tra le scene
    private static ScoreManager instance;

    void Awake()
    {
        // Se esiste già un'istanza, distruggi questo GameObject (evita duplicati)
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Metodo per incrementare il punteggio di c1
    public void IncrementScoreC1()
    {
        scoreC1++;
    }

    // Metodo per incrementare il punteggio di c2
    public void IncrementScoreC2()
    {
        scoreC2++;
    }

    // Metodo per ottenere il punteggio di c1
    public int GetScoreC1()
    {
        return scoreC1;
    }

    // Metodo per ottenere il punteggio di c2
    public int GetScoreC2()
    {
        return scoreC2;
    }

    // Aggiungi questo metodo alla classe ScoreManager
    public void ResetScores()
    {
        scoreC1 = 0;
        scoreC2 = 0;
    }

}
