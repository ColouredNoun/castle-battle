using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Unit : MonoBehaviour {

    //------Variables-----//
        float dmg;
        int ArmorValue;
        string ArmorType;
        int CurrentMana;
        int MaxMana;
        int MoveSpeed;
        int AttackRange;
        string AttackType;
        int AttackValue;
        int AttackSpeed;
        int Turnspeed;
        int UnitValue;
        string UnitName;
        public float UnitHP;
    //--------------------//


    //-----------Unit-Images------------//

    //----------------------------------//

    //------------GameObjects-----------------//

    //----------------------------------------//

    //--------Other-Scripts-Include------//

    //----------------------------------//


    //-----Bools-----//
          bool IsDead;
    //--------------//

    

	// Use this for initialization
	void Start ()
        {
            IsDead = false;
            GetComponent<HealthBar>().SetMaxHealth(UnitHP);
            GetComponent<HealthBar>().SetCurrentHealth(UnitHP);
            GetComponent<HealthBar>().SetPercentage();
            
            

	    }
	
	// Update is called once per frame
    void Update()
    {
        
    }
    //------SET AND GET ARMOR VALUE-------//
    public void SetArmorValue(int PlusArmor)
    {
        ArmorValue = PlusArmor;

    }

    public int GetArmorValue()
    {
        return ArmorValue;
    }
    //-----------------------------------//
}