﻿using UnityEngine;
using System.Collections;

public class AttackTarget : MonoBehaviour {
    public GameObject Target;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Target = this.GetComponent<SearchClosestTarget>().LockedonGameObject;
        print(Target.name);

	}
}
