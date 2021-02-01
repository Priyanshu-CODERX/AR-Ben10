using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechanger : MonoBehaviour
{

    public void StartGame(){
    	SceneManager.LoadScene("mainScene");
    }

    public void quitGame(){
    	Debug.Log("Quitting");
    	Application.Quit();
    }

    public void backToMenu(){
    	SceneManager.LoadScene("MainMenu");
    }

    public void instructionsScene(){
        SceneManager.LoadScene("Instructions");
    }

    public void aboutScene(){
        SceneManager.LoadScene("About");
    }

}
