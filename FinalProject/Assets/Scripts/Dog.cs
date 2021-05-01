using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
	
	public float speed = .1f;
	
	
	private Rigidbody rb;
	
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
		float xDirection = Input.GetAxis("Vertical");
		float zDirection = Input.GetAxis("Horizontal");
	   
	   Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
	   
	   transform.position += moveDirection * speed;
	   
    }
	
	
	void OnTriggerEnter(Collider other){
		
		if (other.gameObject.CompareTag("Eat")){	
			other.gameObject.SetActive(false);
			
		}
	}
	
	
	void OnCollisionEnter( Collision coll ) { // a
	// Find out what hit this basket
	GameObject collidedWith = coll.gameObject; // b
	if ( collidedWith.tag == "Furniture" ) { // c
		print("Collision Detected");
		}}

	
	
	
}
