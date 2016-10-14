using UnityEngine;
using System.Collections;

public class UnitMovement : MonoBehaviour {

    public Transform target;
    private float Speed = 2f;
    private Vector3 rotateSpeed = Vector3.down * 50f;

   


    // Use this for initialization
    void Start () {

        
 
	}
	
	// Update is called once per frame
	void Update () {

        MovementToTarget();
        //nav.SetDestination(player.position);

        //Find Castle then movetowards it this should always be overridden by closest unit
       // Movement();

	}
    void MovementToTarget()
    {
        // THe default target is the castle but this can be changed with the change target function
        //This needs to be edited so that it rotates until it faces a certain target
        //transform.Rotate(rotateSpeed * Time.deltaTime);

        Vector3 targetDir = target.position - transform.position;
        float step = Speed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
        Debug.DrawRay(transform.position, newDir, Color.red);
        transform.rotation = Quaternion.LookRotation(newDir);


        transform.position = Vector3.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);

    }
   public void ChangeTarget(Transform newTarget)
    {
        target = newTarget;

    }

    }
