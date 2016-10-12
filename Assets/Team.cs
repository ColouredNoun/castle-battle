using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Team : MonoBehaviour {

    List<string> playersNames = new List<string>();
    List<string> playersTeams = new List<string>();

    // Use this for initialization
    void Start () {
        playersNames.Add("Open");
        playersNames.Add("Closed");



        playersTeams.Add("Red");
        playersTeams.Add("Blue");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
