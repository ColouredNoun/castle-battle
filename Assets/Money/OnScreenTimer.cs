﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnScreenTimer : MonoBehaviour {

    public Text counterText;
    public float seconds, minutes;

	// Use this for initialization
	void Start () {
        counterText = GetComponent<Text>() as Text;


	}
	
	// Update is called once per frame
	void Update () {


        minutes = (int)(Time.timeSinceLevelLoad / 60f);
        seconds = (int)(Time.timeSinceLevelLoad % 60f);
        counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
	}
}
