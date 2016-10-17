using UnityEngine;
using System.Collections;

public class Zombear : Unit {

    // Use this for initialization
    void Start ()
    {
        UnitInit();

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
        healthbar.SetMaxHealth(UnitHP);
        healthbar.SetCurrentHealth(UnitHP);
        UnitHP = healthbar.GetCurrentHealth();
        
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (IsDead == false) 
        { 
        UnitHP -= 0.5f;
        healthbar.SetCurrentHealth(UnitHP);
        UnitHP = healthbar.GetCurrentHealth();
        healthbar.SetPercentage();
            if (UnitHP == 0)
            {
                IsDead = true;
            }
        }
       if (IsDead == true)
        {
            GameObject.Destroy(gameObject);
        }
	}
}
