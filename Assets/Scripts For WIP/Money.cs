using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Money : MonoBehaviour {

	public int money;
	public Text moneyText;

	// Use this for initialization
	void Start () {
	

			money = 100;
		moneyText.text = money.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addMoney(int moneyToAdd){

		money += moneyToAdd;
        moneyText.text = money.ToString ();
	}

	public void subtractMoney(int moneyToSubtract){

		if (money - moneyToSubtract <= 0) {
			
			Debug.Log ("You can't actually afford that!");
		//	money = 0;
		//	moneyText.text = money.ToString ();
		} else {
			
			money -= moneyToSubtract;
			moneyText.text = money.ToString ();
		}
	}
}
