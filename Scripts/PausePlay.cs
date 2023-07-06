using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PausePlay : MonoBehaviour
{
    private Button buttonComponent;
    public AudioSource pauseAudio;
    public AudioSource playAudio;

    public GameObject CanvasPause;

    private void Awake()
    {
        buttonComponent = GetComponent<Button>();

    }

    public void Pause()
    {
        pauseAudio.enabled = false;
        Time.timeScale = 0;
        CanvasPause.SetActive(true);
        pauseAudio.enabled = true;
    }
    public void Play()
    {
        playAudio.enabled = false;
        Time.timeScale = 1;
        CanvasPause.SetActive(false);
        playAudio.enabled = true;
    }
    public void Restart()
    {
        playAudio.enabled = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        playAudio.enabled = true;
    }
}
