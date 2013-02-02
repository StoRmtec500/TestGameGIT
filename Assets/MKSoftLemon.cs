using UnityEngine;
using System.Collections;

public class MKSoftLemon : MonoBehaviour {
	
	public string erstelltVon = "Martin";
	public string Version = "1.0";
	public string _= " ";
	
	public GameObject Lemon;
	public bool aktiviert;
	
	public static MKSoftLemon instance;
	
	void Awake()
	{
		MKSoftLemon.instance = this;	
	}
	
	// Use this for initialization
	void Start () {
		Lemon = GameObject.FindGameObjectWithTag("Lemon");
	}
	
	// Update is called once per frame
	void Update () {
		if(aktiviert == true)
		{
			rigidbody.isKinematic = false;	
		}
		else
		{
			rigidbody.isKinematic = true;
		}
	}
}
