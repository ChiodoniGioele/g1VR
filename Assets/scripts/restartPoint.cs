using UnityEngine;

public class RestartPoint : MonoBehaviour
{
    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Metodo chiamato quando il bottone viene premuto
    public void OnButtonPress()
    {
        scoreManager.ResetScores();
    }
}
