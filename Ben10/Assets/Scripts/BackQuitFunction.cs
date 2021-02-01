using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackQuitFunction : MonoBehaviour
{
    [SerializeField] GameObject exitPanel;

    void Update(){
    	if(Input.GetKeyDown(KeyCode.Escape)){
    		if(SceneManager.GetActiveScene().buildIndex == 0){
    			exitPanel.SetActive(true);
    		}
    		else{
    			SceneManager.LoadScene(0);
    		}
    	}
    }

    // void Update(){
    // 	if(SceneManager.GetActiveScene().buildIndex != 0){
    // 		SceneManager.LoadScene(0);
    // 	}
    // 	else{
    // 		if(exitPanel) {
    // 			exitPanel.SetActive(true);
    // 		}
    // 	}
    // }
}
