using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour {

    public float mass = 1.0f;
    public float maximumSpeed = 10.0f;
    public Vector3 velocity;
    public GameObject Leader;
    private Vector3 offset;


	// Use this for initialization
	void Start () {
        offset = transform.position - Leader.transform.position;
        offset = Quaternion.Inverse(Leader.transform.rotation) * offset;
        
	}
	
	// Update is called once per frame
	void Update () {    
        velocity = Seek(Leader.transform.TransformPoint(0, 0, 1000));
        Leader.transform.Translate(velocity*Time.deltaTime);

	}

    public Vector3 Seek(Vector3 Target)
    {
        //Vector3 toTarget = target.transform.position - transform.position;
        Vector3 desired = Target - transform.position;
        desired.Normalize();
        desired *= maximumSpeed;
        return desired - velocity;
    }

    public void OffsetPursue(Vector3 leader)
    {
        
    }
}
