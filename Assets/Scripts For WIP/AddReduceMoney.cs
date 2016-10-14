using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AddReduceMoney : MonoBehaviour
{

    public GameObject camera;
    public bool giveIncome;
    public int income;
    public Text incomeText;
  

    public void addIncome() {
        camera.GetComponent<Money>().addMoney(income);
  }

    void Start()
    {
        income = 15;
        giveIncome = true;
        StartCoroutine("waitForIncome");

       incomeText.text = income.ToString();
    }

    IEnumerator waitForIncome() {
        while (giveIncome) {
          //  Debug.Log("Timer For Income Started!");
            yield return new WaitForSeconds(2);
          //  Debug.Log("Here's your income! Have fun");
            addIncome();
        }
    }


    void update()
    {
   
       
        
       


    }

}