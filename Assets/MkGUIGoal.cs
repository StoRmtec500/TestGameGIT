using UnityEngine;
using System.Collections;

public class MkGUIGoal : MonoBehaviour {
	
	public static MkGUIGoal instance;
	public bool GUIEnable = true;
	public int Status = 1;
	
	// Use this for initialization
	public void Awake () {
	MkGUIGoal.instance = this;
	}
	
	public void OnGUI()
	{
		if(GUIEnable)
		{
			switch(Status)
		{
		case 2:
		GUI.BeginGroup(new Rect(100,100,100,100));
		GUI.Label(new Rect(30,30,50,50),"Es geht");
		GUI.EndGroup();
		break;
				
		case 1:
		GUI.BeginGroup(new Rect(100,100,100,100));
		GUI.Label(new Rect(30,30,50,50),"Offline");
		GUI.EndGroup();
		break;
		}
		//return;
		}
	}
}
