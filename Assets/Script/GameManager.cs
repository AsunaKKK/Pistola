using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject PauseGameUi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
    }

    //Pause Game
    public void PauseGame()
    {  
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Time.timeScale == 1)
            {
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
                PauseGameUi.SetActive(true);
            }

        }

    }
    public void OnGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        PauseGameUi.SetActive(false);
    }
    //load scene 
    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    //ExitGame
    public void ExitGame()
    {
        Application.Quit();
    }



}
