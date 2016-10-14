using UnityEngine;
using System.Collections;

public class RTScamera : MonoBehaviour {


    public float horizontalSpeed = 40;
    public float verticalSpeed = 40;
    public float cameraRotateSpeed = 80;
    public float cameraDistance = 30;

    float curDistance;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        float horizontal = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * verticalSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Rotation");

        transform.Translate(Vector3.forward * vertical);
        transform.Translate(Vector3.right * horizontal);

        if (rotation != 0)
        {
            transform.Rotate(Vector3.up, rotation * cameraRotateSpeed * Time.deltaTime, Space.World);
        }

        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit, 100))
        {
            curDistance = Vector3.Distance(transform.position, hit.point);
        }

        if (curDistance != cameraDistance)
        {
            float difference = cameraDistance - curDistance;
            transform.position = Vector3.Lerp(transform.position, transform.position + new Vector3(0, difference, 0), Time.deltaTime);
        }

    }
}
