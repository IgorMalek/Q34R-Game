using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameEnded = false;
    public float delayTime = 1f;
    public GameObject CompleteLevelUI;
    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }

    public void GameOver()
   {
    if (GameEnded == false)
    {
        GameEnded = true;
        Debug.Log("GameOver");
        Invoke("Restart", delayTime); 
  
    }
   }

   void FixedUpdate()
    {
        if (Input.GetKey("r"))
        {
            Restart(); 
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
