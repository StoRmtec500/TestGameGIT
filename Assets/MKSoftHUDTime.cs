using UnityEngine;
using System.Collections;
using System;

public class MKSoftHUDTime : MonoBehaviour {
	
	public string erstelltVon = "Martin";
	public string Version = "1.0";
	public string _= " ";
	
	public exSpriteFont Zeitfont;
	public exSpriteFont Anzahl;
	public float StartTime;
	public bool start;
	public string Punkte;
	
	public static MKSoftHUDTime instance;
	
	void Awake()
	{
		MKSoftHUDTime.instance = this;	
		Anzahl = GameObject.Find("Anzahl").GetComponent<exSpriteFont>();
		Zeitfont = GameObject.Find("mm:ss").GetComponent<exSpriteFont>();
	}
	void Start()
	{
		Zeitfont.text = StartTime.ToString();
		Punkte = PlayerPrefs.GetString("Punkte");
	}
	
	// Update is called once per frame
	public void Update () {
		startTime();
	}
	
	public void punkteerhalten()
	{
		Punkte = MKSoftGameManager.instance.punktint.ToString();
	}
	
	public void startTime()
	{
		if(start == false)
		{
			Time.timeScale = 0;
		}
		else
		{
			float TimeLeft = StartTime - Time.time;
			Time.timeScale = 1;
				if(TimeLeft < 0) TimeLeft = 0;
					Zeitfont.text = String.Format("{0:0}", TimeLeft % 60);
		
				if(TimeLeft == 0)
				{
					Time.timeScale = 0;
					MKSoftMessage.instance.anzeige(MKSoftMessages.Zeit_abgelaufen);
				}
			}
		{
			Anzahl.text = Punkte;		
		}
	}
}
