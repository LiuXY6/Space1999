using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleSpawner : MonoBehaviour {

    public float gap = 20;
    public float followers = 2;
    public GameObject Follower;
    public GameObject Leader;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Awake()
    {
        for (int i = 0; i <= followers; i++)
        {
            GameObject eagle = GameObject.Instantiate(Follower);
            eagle.transform.rotation = Leader.transform.rotation;
            eagle.transform.position = Leader.transform.TransformPoint(new Vector3(gap*i, 0, -gap*i));
            eagle.transform.position = Leader.transform.TransformPoint(new Vector3(-gap*i, 0, -gap*i));
        }
        

    }
}
