using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Unit : MonoBehaviour {

    //------Variables-----//
        int MaxHealth;
        int CurrentHealth;
        int ArmorValue;
        string ArmorType;
        int CurrentMana;
        int MaxMana;
        int MS;
        int Range;
        string AttackType;
        int AttackValue;
        int AttackSpeed;
        int Turnspeed;
        int UnitValue;
    //--------------------//


    //-----------Unit-Images------------//
        public Image CurrentHealthImage;
        public Image HealthBarBackGround;
    //----------------------------------//


    //--------Other-Scripts-Include------//
        UnitMovement unitmovement;
    //----------------------------------//


    //-----Bools-----//
        bool isDead;
        bool damaged;
    //--------------//

    

	// Use this for initialization
	void Start () {
        MaxHealth = 100;
        CurrentHealth = MaxHealth;
        
	}
	
	// Update is called once per frame
	void Update () 
    {
   
       if (damaged)
        {

        }



        damaged = false;
	}

    public void TakeDamage(int amount)
    {
        damaged = true;

        CurrentHealth -= amount;

        
    }


}