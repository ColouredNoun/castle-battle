using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour {
    
    //---Variables---//
    float MaxHealth;
    float CurrentHealth;
    float HealthPercent;
    float CalculatedHP;
    //---------------//

    //----------Images------------//

    //----------------------------//

    //-----Bools-----//
    bool IsDead;
    //--------------//
    //--------Other-Scripts-Include------//

    //----------------------------------//

    //----------Game-Objects-------------//
    public Transform UnitHealthBar;
    public Transform UnitHealthBarDrain;
    //----------------------------------//

	// Use this for initialization
	void Start () 
    {
        UnitHealthBar = GameObject.Find("HPGreen").transform;
        UnitHealthBarDrain = GameObject.Find("HPRed").transform;
    }
	
	// Update is called once per frame
	void Update () 
    {
     
        CalculatedHP = CurrentHealth / MaxHealth;
        if (UnitHealthBar.transform.localScale.x < UnitHealthBarDrain.transform.localScale.x)
        {
            UnitHealthBarDrain.transform.localScale = new Vector3(UnitHealthBarDrain.transform.localScale.x-0.01f,UnitHealthBarDrain.transform.localScale.y,UnitHealthBarDrain.transform.localScale.z);
        }
        
        if (CurrentHealth == 0f)
        {
            IsDead = true;
        }
        if (IsDead == true)
        {
            //KILL
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

    public void SetPercentage()
    {
        print("working");
        UnitHealthBar.transform.localScale = new Vector3(CalculatedHP, UnitHealthBar.transform.localScale.y, UnitHealthBar.transform.localScale.z);
    }
    public float GetPercentage()
    {
        return CalculatedHP*100;
    }

}
