using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public AudioSource startAudio;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void LoadScene()
    {
        startAudio.enabled = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        startAudio.enabled = true;
    }
    public void RetryScene()
    {
        startAudio.enabled = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        startAudio.enabled = true;
    }

    public void QuitToMainMenu()
    {
        startAudio.enabled = false;
        SceneManager.LoadScene("MainMenu");
        startAudio.enabled = true;
    }
}
