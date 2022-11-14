using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDellay = 1f;

    public GameObject completeLevelUI;

    public void ComleteLevel ()
    {
        Debug.Log("Level Won!");

        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDellay);
        }
    }

        void Restart ()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
