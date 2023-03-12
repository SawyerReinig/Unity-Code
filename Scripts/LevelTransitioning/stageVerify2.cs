using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class stageVerify2 : MonoBehaviour
{
    public static int StageAllowed = 1;


    public GameObject[] Buttons;
    public Text[] ButtonTexts;
    public string[] VerifiedNames;  
    public static int highScore = 0; 


    public static bool AllowEndless;
    public static bool[] AllowLevels; 
 

    // Start is called before the first frame update
    void Start()
    {
        if(ScoreKeeper.playerpoints >= 16){
            AllowEndless = true; 
        }
        else{
            if(highScore < ScoreKeeper.playerpoints){
                highScore = ScoreKeeper.playerpoints;
                ScoreKeeper.playerpoints = 0; 
            }
        }

        if(StageAllowed >= 2){
            AllowWorld2(); 
        }


        if(AllowEndless){
            AllowEndless2(); 
        } 

        else{
        ButtonTexts[1].text = "Locked \n Need an Endless Score of 16 \n Current High Score = " + highScore;
        
        }
    }

    void Update()
    {
       
    }

    public void AllowWorld2(){
        Buttons[0].GetComponent<Image>().color = Color.green;
        Buttons[0].GetComponent<Button>().enabled = true; 
        ButtonTexts[0].text = VerifiedNames[0];
    }

     public void AllowEndless2(){
        Buttons[1].GetComponent<Image>().color = Color.green;
        Buttons[1].GetComponent<Button>().enabled = true; 
        ButtonTexts[1].text = VerifiedNames[1];
        ButtonTexts[1].fontSize = 75;
    }
}