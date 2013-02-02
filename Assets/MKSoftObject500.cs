using UnityEngine;
using System.Collections;

public class MKSoftObject500 : MonoBehaviour {

	public int ForceWert;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	rigidbody.AddForce(-Vector3.up * ForceWert);
	}
}
