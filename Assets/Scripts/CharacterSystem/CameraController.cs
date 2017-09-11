using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform playerTransform;
    public Camera playerCamera;
    private Transform camTransform;
    private Vector3 camRelativePosition;
    private float camDefaultDistance = 10f;
    public float camDistance;
    public float zoomSpeed = 10f;
    public float minDistance = 2f;
    public float maxDistance = 20f;
    private float scrollV;
    private float angleH = 0;
    private float angleV = 0;
    


	void Start () {

        camTransform = playerCamera.GetComponent<Transform>();
        camRelativePosition = new Vector3(0f, 7.5f, -10f);
        camRelativePosition = (camRelativePosition / camRelativePosition.magnitude) * camDefaultDistance;
        
        camTransform.position = playerTransform.position + camRelativePosition;
        camTransform.LookAt(playerTransform);

        camDistance = camDefaultDistance;

        angleH = camTransform.rotation.eulerAngles.y;
        angleV = -camTransform.rotation.eulerAngles.x;

    }
	
	void Update () {
		
        if((scrollV = Input.GetAxis("Mouse ScrollWheel")) != 0)
        {
            //zoom in and out
            camDistance += scrollV * zoomSpeed;
            if (camDistance < minDistance)
            {
                camDistance = minDistance;
            } else if (camDistance > maxDistance) {
                camDistance = maxDistance;
            }
            camRelativePosition = camTransform.position - playerTransform.position;
        }

        if(Input.GetMouseButton(0) || Input.GetMouseButton(1)) 
        {
            //pivot camera around player
        }

        if(Input.GetKeyDown(KeyCode.V))
        {
            //reset the camera view
            camRelativePosition = new Vector3(0f, 7.5f, -10f);
            camRelativePosition = (camRelativePosition / camRelativePosition.magnitude) * camDefaultDistance;
            camTransform.position = playerTransform.position + camRelativePosition;
            camTransform.LookAt(playerTransform);
        }

        camTransform.position = playerTransform.position + (camRelativePosition / camRelativePosition.magnitude) * camDistance;

    }
}
