using UnityEngine;
using System.Collections;

public class SearchClosestTarget : MonoBehaviour {
    float radius;
    public Vector3 center;
    public string LockedonTarget;
    bool lockedOn;
    bool DetectedUnitFaction;
    // Use this for initialization
    void Start () {
        lockedOn = false;
        radius = 20f;
	}

    public bool checkIfColliderIsEnemy(int Faction)
    {
        if (Faction == this.gameObject.GetComponent<Faction>().Team)
        {
            Debug.Log(this.gameObject.name + "Says:Hello Friend");
            return false;
        }
      else
        {
            Debug.Log("Intruder Detected");
            return true;
        }

    }


    // Update is called once per frame
    void Update () {
        center = this.transform.position;
        if (lockedOn == false)
        {
            Collider[] hitColliders = Physics.OverlapSphere(center, radius);

            for (int i = 0; i < hitColliders.Length; i++)
            {
                if (hitColliders[i].gameObject.GetComponent<Faction>() != null)
                {
                    DetectedUnitFaction = checkIfColliderIsEnemy(hitColliders[i].gameObject.GetComponent<Faction>().Team);
                    if (DetectedUnitFaction == true)
                    {
                        //Grow in size
                        this.transform.localScale = new Vector3(12, 12, 12);

                        UnitMovement unitmovement = this.GetComponent<UnitMovement>();
                        LockedonTarget = hitColliders[1].transform.ToString();
                        unitmovement.ChangeTarget(hitColliders[1].transform);

                        lockedOn = true;
                    }
                }
            }

        }

       // Debug.Log(hitColliders.Length);
    }
}
