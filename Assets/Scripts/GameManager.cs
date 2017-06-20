using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isTyping; //starts typing stream
    public static float playerHealth; //player's health 
    public static ArrayList questionList = new ArrayList();
    public static ArrayList answerList = new ArrayList();

    private void Update()
    {
        //Debug.Log(playerHealth);
    }
}
