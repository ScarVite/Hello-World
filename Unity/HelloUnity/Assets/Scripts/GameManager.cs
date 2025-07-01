using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 2f;
    bool gameEnded = false;

    public void gameOver()
    {
        if(!gameEnded)
        {
            gameEnded = true;
            Invoke("restart", restartDelay);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
