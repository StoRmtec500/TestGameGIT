using UnityEngine;
using System.Collections;

public class MkLemon : MonoBehaviour {

	public GameObject Goal;
	public GameObject Lemon;
	
	// Use this for initialization
	void Start () {
	Goal = GameObject.FindGameObjectWithTag("Goal");
	Lemon = GameObject.FindGameObjectWithTag("Lemon");
	}
	
	void OnCollisionEnter(Collision Goal)
	{
		if(Goal.gameObject.tag == "Goal")
		{
			LemonJump();	
		}
	}
	
	public void LemonJump()
	{
		Debug.Log("Lemon springt");	
		Lemon.transform.position = new Vector3(0,2,0);
	}
}
