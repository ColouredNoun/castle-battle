using UnityEngine;
using System.Collections;

public class Experience : MonoBehaviour
{
    // lvl is the int used for the characters level
    int lvl;
    // xp is the int used for the characters experience points
    int xp;
    // xpm is the experience points requirement to level up
    int xpm;
    // I is an incriment
    int I;
    //test is for the difference between levels
    int test;
    // also a debug tester with test 
    int xpm2;
    // test for adding exp
    void Exp()
    {

        if (Input.GetKeyDown("space"))
        {
            xp = xp + 500;

            Debug.Log("Level " + lvl.ToString() + " Exp " + xp.ToString() + "/" + xpm.ToString());
        }
    }
    //function that gets called to see if they have enough exp to level up and when they do it levels them up.
    void lvlUp() 
    {

        xpm2 = xpm;
        xp = 0 + (xp - xpm);
        lvl = lvl + 1;
        xpm = (lvl * 4 + lvl) + (((lvl + 1) / 2) + 4) + ((lvl * 3) * lvl);
        test = xpm - xpm2;
        Debug.Log("Level " + lvl.ToString() + " Exp " + xp.ToString() + "/" + xpm.ToString());

        Debug.Log(test);
        Debug.Log("Level up");
    }


    // Use this for initialization
    void Start()
    {
      //------init------//
            lvl = 1;
            xpm = 10;
      //------init------//


    }
    // Update is called once per frame
    void Update()
    {


        Exp();
        if (xp >= xpm)
        {
            lvlUp();
        }
    }
}