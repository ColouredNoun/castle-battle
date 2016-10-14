using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Faction : MonoBehaviour {

    public GameObject castle1;
    public GameObject castle2;

    public int Team;
 
    public void FactionChooser(string castleSummonedFrom)
    {
        if (castleSummonedFrom == "Castle1")
        {
            Team = 1;
           
          
        }
        if (castleSummonedFrom == "Castle2")
        {
            Team = 2;
         
        }
      
    }
    public Color FactionColor()
    {

        if (Team == 1)
        {
            return Color.red;
        }
        if (Team == 2)
        {
            return Color.blue;
        }
        return Color.black;

    }
   public Transform EnemyFinder()
    {

        if (Team == 1)
        {
            castle2 = GameObject.FindWithTag("Castle2");
            
            return castle2.transform;
        }
        if (Team == 2)
        {
            castle1 = GameObject.FindWithTag("Castle1");
            
            return castle1.transform;
        }
        return null;
    }

        void Start()
    {
         
     
       
    }

    void Update()
    {
       
    }
  }
