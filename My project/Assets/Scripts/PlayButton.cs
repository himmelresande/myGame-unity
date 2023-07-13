using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayButton : MonoBehaviour

{
    [SerializeField] GameObject PlayLogo;

    
   
    public void ToGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

}
