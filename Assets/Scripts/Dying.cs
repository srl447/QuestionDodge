using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dying : MonoBehaviour
{

	void Update ()
    {
		if(GameManager.playerHealth < -60)
        {
            SceneManager.LoadScene(1);
        }
	}
}
