using UnityEngine;
using System.Collections;

public class globalTimerScript : MonoBehaviour
{

	public float Timer;

	public float globalTime()
	{
		Timer += Time.deltaTime;
		
		return Timer;
	}

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update(){

		globalTime();
	}
}
