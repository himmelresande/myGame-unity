using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Pause : MonoBehaviour

{
    [SerializeField] GameObject PausePanel;

    private void Awake()
    {
        PausePanel.SetActive(false);
    }
    public void SetPause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void PauseOff()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void ToMenu()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }

}
