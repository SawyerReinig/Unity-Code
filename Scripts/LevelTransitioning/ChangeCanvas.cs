using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCanvas : MonoBehaviour
{

    public Canvas MainCanvas; 
    public Canvas World1Canvas;
    public Canvas World2Canvas;

    public void ShowMainCanvas(){
        
        MainCanvas.enabled = true;
        World1Canvas.enabled = false;
        World2Canvas.enabled = false;
    }
    public void ShowWorld1Canvas(){
        
        MainCanvas.enabled = false;
        World1Canvas.enabled = true;
        World2Canvas.enabled = false;
    }
    public void ShowWorld2Canvas(){
        
        MainCanvas.enabled = false;
        World1Canvas.enabled = false;
        World2Canvas.enabled = true;
    }

    
}
