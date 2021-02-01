using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class urllink : MonoBehaviour
{
    public void OpenDownloadLink(){
    	Debug.Log("Downloading...");
    	Application.OpenURL("https://drive.google.com/file/d/1vMRmQrLDnF1T_176U22EdDg-gbSaHOIu/view?usp=sharing");
    }

    public void OpenFacebookLink(){
    	Debug.Log("Opening FB");
    	Application.OpenURL("https://www.facebook.com/priyanshu.bhattacharjee.58/");
    }

    public void OpenInstagramLink(){
    	Debug.Log("Opening Insta....");
    	Application.OpenURL("https://www.instagram.com/priyanshu_coderx/");
    }
    
    public void OpenLinkedinLink(){
        Debug.Log("Opening linkedin.....");
        Application.OpenURL("https://www.linkedin.com/in/priyanshu-bhattacharjee-438ab01b5/");
    }
    
    public void OpenYoutubeLink(){
        Debug.Log("Opening YouTube......");
        Application.OpenURL("https://www.youtube.com/channel/UCeAsxa9YGGHK2lmTu6Q-DWA");
    }
}
