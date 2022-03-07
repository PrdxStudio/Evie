using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadScene("TestLevel");
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void BugsBtn() {
        SceneManager.LoadScene("Bugs");
    }
}
