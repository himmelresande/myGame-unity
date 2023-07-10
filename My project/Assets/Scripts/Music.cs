using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    private static Music instance;

    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Select(int NumberInBuild)
    {
        SceneManager.LoadScene(NumberInBuild);
        Destroy(GameObject.Find("AudioSource"));
    }
}
