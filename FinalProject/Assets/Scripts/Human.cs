using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
	public Transform target;
	public float speed = 2f;
	Rigidbody rig;
	
	
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		// makes human move towards dog
		Vector3 pos = Vector3.MoveTowards(transform.position , target.position, speed * Time.fixedDeltaTime );
		rig.MovePosition(pos);
		transform.LookAt(target);
	   
    }
}
