using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Unit : MonoBehaviour
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

    //----------------------------------//


    //-----Bools-----//
    bool IsDead;
    //--------------//



    // Use this for initialization
    void Start()
    {
        IsDead = false;

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