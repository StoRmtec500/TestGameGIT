using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MKSoftBox : MonoBehaviour {
	
	public GameObject Lemon;
	
	void Start()
	{
		Lemon = GameObject.FindGameObjectWithTag("Lemon");
	}

	void OnCollisionEnter(Collision destroy)
	{
		if(destroy.gameObject.tag == "Lemon")
		{
			GameObject.Destroy(Lemon);
			MKSoftHUDTime.instance.start = false;
			MKSoftMessage.instance.anzeige(MKSoftMessages.Erfolgreich);
			MKSoftGameManager.instance.punktint += System.Int32.Parse(MKSoftHUDTime.instance.Zeitfont.text);
			MKSoftGameManager.instance.savePunkte(MKSoftGameManager.instance.punktint.ToString());
			MKSoftHUDTime.instance.punkteerhalten();
		}
		else
		{
			Debug.Log("nichts passiert");
		}
	}
}
