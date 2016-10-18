using UnityEngine;
using System.Collections;

public class Zombunny : Unit
{

    // Use this for initialization
        void Start()
    {
        UnitHP = 200;
        ArmorType = "Cloth";
        CurrentMana = 100;
        MaxMana = 100;
        MoveSpeed = 10;
        AttackRange = 150;
        AttackType = "Spear";
        AttackValue = 30f;
        AttackSpeed = 0.8f;
        Turnspeed = 10;
        UnitValue = 100;
        UnitName = "Zombunny";
        int Team = this.GetComponent<Faction>().Team;
        int UpgradeLevel = GameObject.Find("Castle" + Team).GetComponent<UnitUpgrades>().UpgradeLevel;
        SetStats(UpgradeLevel);

        this.GetComponent<UnitMovement>().Speed = MoveSpeed;
        UnitInit();
        SetPercentage();


    }

    // Update is called once per frame
    void Update()
    {
        MoveBar();
        if (IsDead == false)
        {
            if (UnitHP <= 0)
            {
                IsDead = true;
            }
            
            AttackTimer();
            Attack();
        }
        if (IsDead == true)
        {
            GameObject.Destroy(gameObject);
        }
    }
    public void SetStats(int CurrentUpgradeLevel)
    {
        UnitHP = UnitHP + ((UnitHP / 10) * CurrentUpgradeLevel);
        ArmorValue = ArmorValue + ((ArmorValue / 10) * CurrentUpgradeLevel);
        CurrentMana = CurrentMana + ((CurrentMana / 10) * CurrentUpgradeLevel);
        MaxMana = MaxMana + ((MaxMana / 10) * CurrentUpgradeLevel);
        AttackValue = AttackValue + ((AttackValue / 10) * CurrentUpgradeLevel);
        AttackSpeed = AttackSpeed + ((AttackSpeed / 10) * CurrentUpgradeLevel);
        SetMaxHealth(UnitHP);
        SetCurrentHealth(UnitHP);

    }
}