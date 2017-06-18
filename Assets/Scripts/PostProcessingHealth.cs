using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class PostProcessingHealth : MonoBehaviour {

    public PostProcessingProfile mainProfile; //file with post-processing info

    //these let you edit the components of the post-processing profile
    ColorGradingModel.Settings colorS;
    BloomModel.Settings bloomS;

    float deltaHealth, oldHealth; //see how much health lost between frames
    public float blueSpeed, bloomSpeed; //control how intense effects are


    // Use this for initialization
    void Start()
    {
        //assigns everything and starts them at default values since script permantely edits file
        colorS = mainProfile.colorGrading.settings;
        colorS.channelMixer.blue = new Vector3(0f, 0f, 1f);
        bloomS = mainProfile.bloom.settings;
        bloomS.bloom.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        deltaHealth = Mathf.Abs(oldHealth - GameManager.playerHealth); //records change in health
        colorS.channelMixer.blue += new Vector3(0, 0, deltaHealth * blueSpeed); //increases blue tint
        bloomS.bloom.intensity += deltaHealth * bloomSpeed; //increases bloom

        //assings the edited settings to the profile
        mainProfile.colorGrading.settings = colorS;
        mainProfile.bloom.settings = bloomS;

        oldHealth = GameManager.playerHealth;//keeps track of old health
    }
}

