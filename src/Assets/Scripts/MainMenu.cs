using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource startSound;

    public void PlayGame()
    {
	    SceneManager.LoadScene(1);
    }

    public static void PlayCredits()
    {
	    SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
	    Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
	    startSound = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
	    //startSound.Play();
        
    }
}
