using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
    float Timer;
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
    void Update () {
 
        }


     void SpawnUnit()
    {
        var NewUnit = Instantiate(Unit, transform.position, Quaternion.identity) as GameObject;
        NewUnit.GetComponent<Animator>().runtimeAnimatorController = EnemyAnimatorController;

        numberofSpawnedUnits++;
        NewUnit.transform.localScale = new Vector3(10, 10, 10);
        NewUnit.AddComponent<Rigidbody>();
        NewUnit.AddComponent<CapsuleCollider>();
        NewUnit.AddComponent<NavMeshAgent>();
        var Faction = NewUnit.AddComponent<Faction>();
        Faction.FactionChooser(this.gameObject.name);
        NewUnit.GetComponentInChildren<SkinnedMeshRenderer>().materials[0].color = Faction.FactionColor();
        Transform Enemy = Faction.EnemyFinder();
        NewUnit.name = ("Zombear" + numberofSpawnedUnits + " " + Faction.Team);
        NewUnit.AddComponent<UnitMovement>().target = Enemy;
        NewUnit.AddComponent<SelectableUnitComponent>();
        NewUnit.AddComponent<Unit>();
        NewUnit.AddComponent<SearchClosestTarget>();
    }


        IEnumerator UnitSpawnTime() {
            while (SpawningUnits)
            {
            SpawnUnit();
            print("cake");
                //  Debug.Log("Timer For Income Started!");
                yield return new WaitForSeconds(15);
            //  Debug.Log("Here's your income! Have fun");
               ;
            }
        }
  }

