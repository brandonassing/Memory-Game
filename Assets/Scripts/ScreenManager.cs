using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour {

    /// <summary>
    /// Controls scene changes
    /// </summary>
    /// 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void LoadPlay()
    {
        SceneManager.LoadScene("_Scene_0");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void LoadGameOver()
    {
        SceneManager.LoadScene("Game Over");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
