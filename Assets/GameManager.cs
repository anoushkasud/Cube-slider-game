using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void NextLevel()
    {
        Invoke("",2.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void GameEnd()
    {
        SceneManager.LoadScene("End Game");
    }

}