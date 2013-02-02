using UnityEngine;
using System.Collections;
using System;

public class MKSoftGameManager : MonoBehaviour {
	
	//Das ist ein Test
	public string erstelltVon = "Martin";
	public string Version = "1.0";
	public string _= " ";
	
	private string punkt;
	public int punktint;
	public int levelname;
	
	public static MKSoftGameManager instance;
	
	void Awake()
	{
		MKSoftGameManager.instance = this;	
		levelname = Application.loadedLevel + 1;
	}
	
	// Use this for initialization
	void Start () {
		punkt = PlayerPrefs.GetString("Punkte");
		punktint = System.Int32.Parse(punkt);
	}
	
	// Update is called once per frame
	void Update () {
		this.LemonStart();	
	}
	
	public void LemonStart()
	{
		if(!MKSoftLemon.instance.aktiviert == true)
		{
			if(Input.GetMouseButtonDown(0))
			{
				MKSoftLemon.instance.aktiviert = true;
				MKSoftHUDTime.instance.start = true;
			}
		}
	}
	
	public void savePunkte(string punkt)
	{
		PlayerPrefs.SetString("Punkte", punkt);	
	}
}
