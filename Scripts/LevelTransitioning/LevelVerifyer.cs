using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelVerifyer : MonoBehaviour
{

    public GameObject[] Buttons;
    public static int AmountOfLevels = 19; 
    public static bool[] AllowLevels = new bool[AmountOfLevels]; 


void Start()
    {
        for(int i = 0; i < AmountOfLevels; i++){
            if(AllowLevels[i] == true){
                Buttons[i].GetComponent<Image>().color = Color.green;
                Buttons[i].GetComponent<Button>().enabled = true;
            }
        }
    }


 
}
