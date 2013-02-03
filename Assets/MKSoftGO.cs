using UnityEngine;
using System.Collections;

public class MKSoftGO : MonoBehaviour {
	
	public exSpriteFont GOButton;
	public bool GOButtonaktiv;
	
	
	void Awake()
	{
		GOButton = GameObject.Find("lbl_GO").GetComponent<exSpriteFont>();
		GOButtonaktiv = false;
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if( iPhoneInput.touchCount >= 1 )

        {

            Ray cursorRay = Camera.main.ScreenPointToRay( iPhoneInput.GetTouch(0).position );
			RaycastHit hit;
			if( collider.Raycast( cursorRay, out hit, 1000.0f ) ) 

	            {
					GOButtonaktiv = true;
	            	LemonStart();
	            }
			}
        }
	
	public void LemonStart()
	{
		if(!MKSoftLemon.instance.aktiviert == true)
		{
			if(GOButtonaktiv)
			{
				Debug.Log("Button gedruckt");
				MKSoftLemon.instance.aktiviert = true;
				MKSoftHUDTime.instance.start = true;
			}
		}
	}
}
