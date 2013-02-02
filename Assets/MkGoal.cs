using UnityEngine;
using System.Collections;

public class MkGoal : MonoBehaviour {

	public GameObject Lemon;
	public GUISkin mySkin;
	private Rect windowsRect;
	public bool paused = false;
	public int score = 1;
	
	// Use this for initialization
	void Start () {
	Lemon = GameObject.FindGameObjectWithTag("Lemon");
	windowsRect = new Rect(Screen.width / 2 - 100, Screen.height /2-100,200,200);
	}
	
	void OnGUI()
	{
		if (paused)
		windowsRect = GUI.Window(0, windowsRect, windowFunc, "Pause Menu");	
		
		GUI.Label(new Rect(10,10,100,30), "Punkte: " + score.ToString());
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if (paused)
			paused = false;
			else
				paused = true;
		}
	}
	
	void OnTriggerEnter()
	{
	if (Lemon.gameObject.tag == "Lemon")
		{
		MkGUIGoal.instance.Status = 2;
			score ++;
		}
	}
	
	private void windowFunc(int id)
	{
		if (GUILayout.Button("Test"))
		if (MkGUIGoal.instance.GUIEnable == false)
			{
			 	MkGUIGoal.instance.GUIEnable = true;
			}
			else
			{
				MkGUIGoal.instance.GUIEnable = false;
			}
	}

}
