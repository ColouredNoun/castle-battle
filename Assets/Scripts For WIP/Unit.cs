using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Unit : MonoBehaviour {

    //------Variables-----//
        float dmg = 20f;
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
        float GruntHP;
        string UnitName;
    //--------------------//


    //-----------Unit-Images------------//

    //----------------------------------//

    //------------GameObjects-----------------//

    //----------------------------------------//

    //--------Other-Scripts-Include------//

    //----------------------------------//


    //-----Bools-----//

    //--------------//

    

	// Use this for initialization
	void Start ()
        {
          
	    }
	
	// Update is called once per frame
	void Update () 
    {
	}

    
    void attack ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            
          Debug.Log("Attacked");

          GruntHP -= dmg;

          print(dmg);
        }
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