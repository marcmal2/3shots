using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
   
   public void ChangeScene(string sceneName){
        SceneManager.LoadScene(sceneName);
   }

   public void QuitGame(){
      Application.Quit();
   }
}
