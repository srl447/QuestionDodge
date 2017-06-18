using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class PostProcessingHealth : MonoBehaviour {

    public PostProcessingProfile mainProfile;

    ColorGradingModel.Settings colorS;
    BloomModel.Settings bloomS;

    float deltaHealth;
    public float blueSpeed, bloomSpeed;
	// Use this for initialization
	void Start ()
    {
        colorS = mainProfile.colorGrading.settings;
        colorS.channelMixer.blue = new Vector3(0f, 0f, 1f);
        bloomS = mainProfile.bloom.settings;
        bloomS.bloom.intensity = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        deltaHealth = deltaHealth - GameManager.playerHealth;
        colorS.channelMixer.blue += new Vector3(0, 0, deltaHealth * blueSpeed);
        bloomS.bloom.intensity += deltaHealth * bloomSpeed;
        mainProfile.colorGrading.settings = colorS;
        mainProfile.bloom.settings = bloomS;

    }
}

