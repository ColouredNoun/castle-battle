using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Unit : HealthBar
{

    //------Variables-----//
    public float UnitHP;
    public float Damage;
    public float ArmorValue;
    public string ArmorType;
    public int CurrentMana;
    public int MaxMana;
    public int MoveSpeed;
    public float AttackRange;
    public string AttackType;
    public float AttackValue;
    public float AttackSpeed;
    public float timer;
    public int Turnspeed;
    public int UnitValue;
    public string UnitName;


    //--------------------//


    //-----------Unit-Images------------//

    //----------------------------------//

    //------------GameObjects-----------------//
    GameObject Target;
    //----------------------------------------//

    //--------Other-Scripts-Include------//

    public Experience XP;
    //----------------------------------//


    //-----Bools-----//
    public bool IsDead;
    bool AttackReady;
    public bool attacked;
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
        SetMaxHealth(UnitHP);
        SetCurrentHealth(UnitHP);
        SetPercentage();
        SetArmorValue(4f);
        
       
        XP = GetComponent<Experience>();
      

        IsDead = false;

    }
    //------SET AND GET ARMOR VALUE-------//

    public void SetArmorValue(float PlusArmor)
    {
        ArmorValue = PlusArmor;

    }

    public float GetArmorValue()
    {
        return ArmorValue;
    }

    //-----------------------------------//
    
    //-------------AttackScript---------------//
    public void Attack()
    {
        Target = this.GetComponent<SearchClosestTarget>().LockedonGameObject;

        if (Target != null && AttackReady ==true)
        {
      
        AttackReady = false;
       
        Target.GetComponent<Unit>().TakeDamage(AttackValue);
  
        timer = 0f;
        }
    }
    //---------------------------------------//

    //===============TakeDamage=====================//
    public void TakeDamage(float Dmg)
    {
   
        Dmg -= GetArmorValue();
        UnitHP -= Dmg;
        SetCurrentHealth(UnitHP);
        SetPercentage();
    }
    //==============================================//

    // Attack speed //
    public void AttackTimer()
    {
        timer += Time.deltaTime;
        
        if (timer >= AttackSpeed)
        { AttackReady = true;
        }
    }

    //=--=-=-=-=-==-//

}