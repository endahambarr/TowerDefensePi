using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void SwitchScene (string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ExitGame ()
    {
        Application.Quit();
    }
}
