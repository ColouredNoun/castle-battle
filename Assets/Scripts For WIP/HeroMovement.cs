using UnityEngine;
using System.Collections;

public class HeroMovement : MonoBehaviour
{

    Vector3 target;
    bool going;
    private float Speed = 2f;

    void Start()
    {
        target = transform.position;
        going = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {       // the button is pressed
            target = Input.mousePosition;
            Debug.Log(target);
            going = true;
        }

        if (going)
        {
            if ((Vector3.Distance(target, transform.position)) > 0.5)
            {
                Vector3 targetDir = target - transform.position;
                float step = Speed * Time.deltaTime;
                Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
                Debug.DrawRay(transform.position, newDir, Color.red);
                transform.position = Vector3.MoveTowards(transform.position, target, Speed * Time.deltaTime);
            }
            else
                going = false;
        }
    }
}