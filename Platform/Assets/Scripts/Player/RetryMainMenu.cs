using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public void MainMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        Point_scriptt.score = 0;
        Health.damage = 0;
    }
    public void Retry()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        Point_scriptt.score = 0;
        Health.damage = 0;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
