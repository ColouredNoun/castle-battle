
using UnityEngine;
using System.Collections;

public class TakeDamage : MonoBehaviour {
   
    //------Variables-----//
    float Amount;
    float armor;
    float health;
    //--------------------//

    //-----------Unit-Images------------//

    //----------------------------------//

    //------------GameObjects-----------------//

    //----------------------------------------//

    //--------Other-Scripts-Include------//
    //----------------------------------//

    //-----Bools-----//
    bool Damaged;
    //--------------//

	// Use this for initialization
	void Start () {
	    Damaged = false;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    //-TakeDamage-function-//
    public void Attacked()
    {
        Damaged = true;
        
    }
    //---------------------//
}
