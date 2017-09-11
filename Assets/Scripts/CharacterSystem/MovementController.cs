using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour {

    public Transform playerTransform;
    public Rigidbody playerBody;
    public float moveSpeed = 1f;
    public NavMeshAgent playerAgent;
    public Camera cam;

	// Use this for initialization
	void Start () {
        playerBody = GetComponent<Rigidbody>();
        playerAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 100f))
            {
                playerAgent.SetDestination(hit.point);
            }

        }
	}
}
