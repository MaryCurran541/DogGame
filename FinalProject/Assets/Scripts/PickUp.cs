using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour //, IPointerClickHandler
{
    public Transform destination;
	
	//OnPointerClick
	
	void OnMouseDown(){
		GetComponent<CapsuleCollider>().enabled = false;
		GetComponent<Rigidbody>().useGravity = false;
		this.transform.position = destination.position;
		this.transform.parent = GameObject.Find("DogTounge").transform;
	}
	
	
	void OnMouseUp(){
		this.transform.parent = null;
		GetComponent<Rigidbody>().useGravity = true;
		GetComponent<CapsuleCollider>().enabled = true;
	}
	
	
}
