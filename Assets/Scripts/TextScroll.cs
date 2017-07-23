using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScroll : MonoBehaviour
{
    public Text scrollText; //text to display all the questions and answers

    string qR; //string to work with
    
	void Start ()
    {

        for (int i = 0; i <= GameManager.questionList.Count - 1; i++) //adds all questions and answers to string
        {
            if (i != GameManager.questionList.Count - 1) //adds questions and response if it isn't the last question
            {
                qR += GameManager.questionList[i] + "\n" + GameManager.answerList[i] + "\n";
            }
            else //last question adds no response
            {
                qR += GameManager.questionList[i] + "\n" + "No Response";
            }
        }

        scrollText.text = qR; //adds string to text
	}
	
	void Update () 
    {
        transform.position += Vector3.up;
	}
}
