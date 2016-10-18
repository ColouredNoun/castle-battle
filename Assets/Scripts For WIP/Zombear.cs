using UnityEngine;
using System.Collections;

public class Zombear : Unit
{

    // Use this for initialization
    void Start()
    {
        UnitHP = 250;
        ArmorType = "Cloth";
        CurrentMana = 100;
        MaxMana = 100;
        MoveSpeed = 10;
        AttackRange = 150;
        AttackType = "Spear";
        AttackValue = 26f;
        AttackSpeed = 1f;
        Turnspeed = 10;
        UnitValue = 100;
        UnitName = "Zombear";
        int Team = this.GetComponent<Faction>().Team;
        int UpgradeLevel = GameObject.Find("Castle" + Team).GetComponent<UnitUpgrades>().UpgradeLevel;
        SetStats(UpgradeLevel);

        this.GetComponent<UnitMovement>().Speed = MoveSpeed;
        UnitInit();


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
        SetMaxHealth(UnitHP);
        SetCurrentHealth(UnitHP);

    }
}