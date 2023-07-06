using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public AudioSource start;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MainMenu()
    {
        start.enabled = true;
        SceneManager.LoadScene("MainMenu");
        start.enabled = true;
    }

    public void LoadGame()
    {
        start.enabled = false;
        SceneManager.LoadScene("Level1");
        start.enabled = true;
    }

    public void Instructions()
    {
        start.enabled = false;
        SceneManager.LoadScene("Instructions");
        start.enabled = true;
    }
    public void Objective()
    {
        start.enabled = false;
        SceneManager.LoadScene("Objective");
        start.enabled = true;
    }
    public void ExitGame()
    {
        start.enabled = true;
        Application.Quit();
        start.enabled = true;
    }
}
