using UnityEngine;
using System.Collections;

public class SearchClosestTarget : MonoBehaviour
{
    float radius;
    public Vector3 center;
    public string LockedonTarget;
    public bool lockedOn;
    bool DetectedUnitFaction;
    int SearchInterval;
    bool ScanningForEnemies;
    public GameObject LockedonGameObject;
    // Use this for initialization
    void Start()
    {
        lockedOn = false;
        radius = 20f;
        SearchInterval = 1;
        ScanningForEnemies = true;
        DetectedUnitFaction = false;
        StartCoroutine("IntializeScanForEnemies");
    }

    public bool checkIfColliderIsEnemy(string name, int Faction)
    {


        if (Faction == this.gameObject.GetComponent<Faction>().Team)
        {

            return false;
        }
        else
        {
            return true;
        }

    }

    public void ScanForEnemies()
    {
        center = this.transform.position;

        if (lockedOn == false)
        {
            Collider[] hitColliders = Physics.OverlapSphere(center, radius);

            for (int i = 0; i < hitColliders.Length; i++)
            {
                if (hitColliders[i].gameObject.GetComponent<Faction>() != null)
                {

                    DetectedUnitFaction = checkIfColliderIsEnemy(hitColliders[i].gameObject.name, hitColliders[i].gameObject.GetComponent<Faction>().Team);
                    //Debug.Log(hitColliders[i].gameObject.GetComponent<Faction>().Team);
                    if (DetectedUnitFaction == true)
                    {
                        //Grow in size

                        UnitMovement unitmovement = this.GetComponent<UnitMovement>();
                        LockedonTarget = hitColliders[i].transform.ToString();
                        LockedonGameObject = hitColliders[i].gameObject;
                        unitmovement.ChangeTarget(hitColliders[i].transform);

                        lockedOn = true;
                        if (LockedonGameObject != null)
                        {
                            lockedOn = false;
                        }
                        
                    }
                }
            }

        }
    }


    IEnumerator IntializeScanForEnemies()
    {
        while (ScanningForEnemies)
        {
            ScanForEnemies();
            yield return new WaitForSeconds(1);
        }
    }
    // Update is called once per frame
    void Update()
    {

        //DebugExtension.DebugCircle(this.transform.position, this.transform.position, Color.green, radius);
    }
}