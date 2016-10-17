using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Unit : HealthBar
{

    //------Variables-----//
    public float UnitHP;
    public float Damage;
    public int ArmorValue;
    public string ArmorType;
    public int CurrentMana;
    public int MaxMana;
    public int MoveSpeed;
    public int AttackRange;
    public string AttackType;
    public int AttackValue;
    public int AttackSpeed;
    public int Turnspeed;
    public int UnitValue;
    public string UnitName;
    //--------------------//


    //-----------Unit-Images------------//

    //----------------------------------//

    //------------GameObjects-----------------//

    //----------------------------------------//

    //--------Other-Scripts-Include------//

    public Experience XP;
    //----------------------------------//


    //-----Bools-----//
    public bool IsDead;
    //--------------//



    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void UnitInit()
    {
     

       
        XP = GetComponent<Experience>();
      

        IsDead = false;

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