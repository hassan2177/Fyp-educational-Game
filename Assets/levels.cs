using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButtonManager : MonoBehaviour
{
    public GameObject mainMenuWindow;
    public GameObject levelsWindow;
    public GameObject credits;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LevelsButton()
    {
        mainMenuWindow.SetActive(false);
        levelsWindow.SetActive(true);
        credits.SetActive(false);
    }

    public void CreditsButton()
    {
        mainMenuWindow.SetActive(false);
        levelsWindow.SetActive(false);
        credits.SetActive(true);
    }

    public void BackButton()
    {
        mainMenuWindow.SetActive(true);
        levelsWindow.SetActive(false);
        credits.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}