using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            GameManager.playerHealth = 0;
            GameManager.answerList.Clear();
            GameManager.questionList.Clear();
        }
	}
}
