using UnityEngine;
using System.Collections;

public class MKSoftMessage : MonoBehaviour {
	
	/*public enum message{
		Zeit_abgelaufen,
		erfolgreich
	}*/
	
	public static MKSoftMessage instance;
	
	public MKSoftMessages status;
	public exSpriteFont Zeitabgelaufen;
	public exSpriteFont erfolgreich;
	
	void Awake()
	{
		MKSoftMessage.instance = this;
	}
	
	void Start()
	{
		Zeitabgelaufen = GameObject.Find("lbl_Zeitabgelaufen").GetComponent<exSpriteFont>();
		Zeitabgelaufen.enabled = false;
		erfolgreich = GameObject.Find("lbl_Erfolgreich").GetComponent<exSpriteFont>();
		erfolgreich.enabled = false;
	}

	public void anzeige(MKSoftMessages anzeigen)
	{
		switch (anzeigen)
		{
		case MKSoftMessages.Erfolgreich:
		{
			erfolgreich.enabled = true;
		}
			break;
		case MKSoftMessages.Zeit_abgelaufen:
		{
			Zeitabgelaufen.enabled = true;
		}
			break;
		}
	}
}
