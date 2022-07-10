using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string scene;
    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
