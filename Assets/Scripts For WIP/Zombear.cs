using UnityEngine;
using System.Collections;

public class Zombear : Unit {
   

    // Use this for initialization
    void Start () {
        UnitHP = 250;
        ArmorValue = 5;
        ArmorType = "Cloth";
        CurrentMana = 100;
        MaxMana = 100;
        MoveSpeed = 10;
        AttackRange = 150;
        AttackType = "Spear";
        AttackValue = 10;
        AttackSpeed = 10;
        Turnspeed = 10;
        UnitValue = 100;
        UnitName = "Zombear";
        this.GetComponent<HealthBar>().SetCurrentHealth(UnitHP);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
