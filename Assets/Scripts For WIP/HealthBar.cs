using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour
{

    //---Variables---//
    float MaxHealth;
    float CurrentHealth;
    float HealthPercent;
    float CalculatedHP;
    //---------------//

    //----------Images------------//

    //----------------------------//

    //-----Bools-----//

    //--------------//
   public Transform UnitHealthBar;
   public Transform UnitHealthBarDrain;
    //--------Other-Scripts-Include------//

    //----------------------------------//

    //----------Game-Objects-------------//

    //----------------------------------//

    // Use this for initialization
    void Start()
    {
       

        CalculatedHP = CurrentHealth / MaxHealth;

    }
    // Update is called once per frame
    void Update()
    {
       
    }
   

public void MoveBar()
{
        CalculatedHP = CurrentHealth / MaxHealth;
        if (UnitHealthBar.transform.localScale.x < UnitHealthBarDrain.transform.localScale.x)
        {
            UnitHealthBarDrain.transform.localScale = new Vector3(UnitHealthBarDrain.transform.localScale.x - 0.001f, UnitHealthBarDrain.transform.localScale.y, UnitHealthBarDrain.transform.localScale.z);
        }
    }


//=========MAX HP SETTERS AND GETTERS=======//

public float GetMaxHealth()
    {
        return MaxHealth;
    }

    public void SetMaxHealth(float UnitHP)
    {
        MaxHealth = UnitHP;
        SetPercentage();
    }

    //=========================================//


    //=========CURRENT HP SETTERS AND GETTERS=======//

    public float GetCurrentHealth()
    {
        return CurrentHealth;
    }
    public void SetCurrentHealth(float UnitHP)
    {
        CurrentHealth = UnitHP;
    }

    //=============================================//

    //=========PercentageHP-Setters-And-Getters=======//
    public void SetPercentage()
    {
        UnitHealthBar.transform.localScale = new Vector3(CalculatedHP, UnitHealthBar.transform.localScale.y, UnitHealthBar.transform.localScale.z);
    }
    public float GetPercentage()
    {
        return CalculatedHP * 100;
    }
    //=============================================//
}