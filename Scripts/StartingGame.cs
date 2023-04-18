using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingGame : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +  1);
    }
}
