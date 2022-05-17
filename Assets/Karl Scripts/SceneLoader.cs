using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SceneLoader : MonoBehaviour
{
    public void QuitGame()
    {// spara json kom ihåg
        Application.Quit();
        Debug.Log("Quit");
    }

    public void Restart()
    {// spara json kom ihåg
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }
}
