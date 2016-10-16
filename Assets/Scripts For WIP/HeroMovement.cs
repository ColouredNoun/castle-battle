using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class HeroMovement : NetworkBehaviour
{
   public GameObject Hero;
    Vector3 target;
    bool going;
    private float rotateSpeed = 45F;
    private float Speed = 10f;
    Animator HeroAnimator;
    public float distanceBetweenPointAndHero;
    void Start()
    {
        target = this.transform.position;
        going = false;
        HeroAnimator = Hero.GetComponent<Animator>();
    }

    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        if (Input.GetMouseButtonDown(1))
        {       // the button is pressed
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //draw invisible ray cast/vector
                Debug.DrawLine(ray.origin, hit.point);
                //log hit area to the console
                target = hit.point;
                HeroAnimator.SetBool("WalkForward", true);
            }

           
            going = true;
        }

        if (going)
        {
            distanceBetweenPointAndHero = Vector3.Distance(target, transform.position);
            if (distanceBetweenPointAndHero > 0.5)
            {
              //  HeroAnimator.SetBool("Idle", false);
                Vector3 targetDir = target - transform.position;
                float step = Speed * Time.deltaTime;
                Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
                Debug.DrawRay(transform.position, newDir, Color.red);
                Quaternion targetRotation = Quaternion.LookRotation(newDir);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
                transform.position = Vector3.MoveTowards(transform.position, target, Speed * Time.deltaTime);


            

                }
           else if (distanceBetweenPointAndHero < 1.4)
            {
                HeroAnimator.SetBool("WalkForward", false);
            }
            else
                going = false;
           
        }
    }
}