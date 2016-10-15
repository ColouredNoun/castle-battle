﻿using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
    float Timer;
    public GameObject HealthBar;
    public GameObject Unit;
    public RuntimeAnimatorController EnemyAnimatorController;
    public GameObject camera;
    bool recentlySpawned;
    int numberofSpawnedUnits;
    float Time;
    bool SpawningUnits;
    // Use this for initialization
    void Start () {
        numberofSpawnedUnits = 0;
        recentlySpawned = false;
        SpawningUnits = true;
        StartCoroutine("UnitSpawnTime");

    }

    // Update is called once per frame
    void Update ()
        {
 
        }

     void SpawnUnit()
    {
        var NewUnit = Instantiate(Unit, transform.position, Quaternion.identity) as GameObject;
        numberofSpawnedUnits++;
        var Faction = NewUnit.GetComponent<Faction>();
        //When Unit is created it is awarded the Faction class
        Faction.FactionChooser(this.gameObject.name);
        //The faction class awards a faction to the unit based on the castle
        NewUnit.GetComponentInChildren<SkinnedMeshRenderer>().materials[0].color = Faction.FactionColor();
        //The colour of the unit is changed based on the faction
        Transform Enemy = Faction.EnemyFinder();
        // The Unit targets the enemy castle based on the faction
        NewUnit.name = ("Zombear" + numberofSpawnedUnits + " " + Faction.Team);
        //The Unit is named based on the spawned Units
        NewUnit.GetComponent<UnitMovement>().target = Enemy;
        //The Unit begins moving to targeted castle
      
        

    }


        IEnumerator UnitSpawnTime() {
            while (SpawningUnits)
            {
            SpawnUnit();
           
                //  Debug.Log("Timer For Income Started!");
                yield return new WaitForSeconds(15);
            //  Debug.Log("Here's your income! Have fun");
               ;
            }
        }
  }

