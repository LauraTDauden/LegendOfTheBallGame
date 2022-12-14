using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string firstLevel;
    public string mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        if (SceneManager.GetSceneByBuildIndex(0).Equals(SceneManager.GetActiveScene())){
              SceneManager.LoadScene(firstLevel);
        } else
        {
            SceneManager.LoadScene(PlayerController.previousScene);
        }
        
    }

    public void OpenOptions()
    {

    }

    public void CloseOptions()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
