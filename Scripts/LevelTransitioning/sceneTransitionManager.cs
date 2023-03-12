using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTransitionManager : MonoBehaviour
{
    public faderscreenscript fadeScreen; 

    public void GoToScene(int sceneIndex){
        
        StartCoroutine(GoToSceneRoutine(sceneIndex)); 
    }

    IEnumerator GoToSceneRoutine(int sceneIndex){
        
        fadeScreen.fadeOut(); 
        yield return new WaitForSeconds(fadeScreen.fadeDuration); 
        SceneManager.LoadScene(sceneIndex); 
        
    }

     public void GoToSceneAsync(int sceneIndex){
        
        StartCoroutine(GoToSceneRoutineAsync(sceneIndex)); 
    }

    IEnumerator GoToSceneRoutineAsync(int sceneIndex){

        yield return null;
       AsyncOperation operation =  SceneManager.LoadSceneAsync(sceneIndex); 
       operation.allowSceneActivation = false; 

       float timer = 0; 
       while(!operation.isDone){
        timer += Time.deltaTime; 
        yield return null; 
       }
       operation.allowSceneActivation = true; 
        yield return new WaitForSeconds(0.1f);
        
    }
}
