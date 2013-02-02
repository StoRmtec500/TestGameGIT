using UnityEngine;
using System.Collections;

public class MKSoftMainMenu : MonoBehaviour {
	
	public int levelname;
	
	void Awake()
	{
		levelname = Application.loadedLevel +1;	
	}
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
		GUI.BeginGroup(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 240, 400,480));
		GUI.Box(new Rect(0,0, 400,480),"Main Menu");
		GUI.Button(new Rect(30,30, 340, 120),"Play");
			if(Input.GetMouseButtonDown(0))
			{
				Application.LoadLevel(levelname);
			}
		GUI.Button(new Rect(30,180, 340,120),"Optionen");
		GUI.Button(new Rect(30,330, 340, 120),"Ende");
		GUI.EndGroup();
	}
}
