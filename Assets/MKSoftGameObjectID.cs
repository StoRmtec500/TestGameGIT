using UnityEngine;
using System.Collections;

public class MKSoftGameObjectID : MonoBehaviour {
	
	public static MKSoftGameObjectID instance;
	
	public string GameObjectID;
	public bool aktive;
	public float speed = 1f;
	
	public void Awake()
	{
		MKSoftGameObjectID.instance = this;
		GameObjectID = gameObject.GetInstanceID().ToString();
	}
	
	public void aktiv()
	{
		if(Input.touchCount > 0)
		this.aktive = true;
	}
	
	void Update()
	{
	if( iPhoneInput.touchCount >= 1 )

        {

            Ray cursorRay = Camera.main.ScreenPointToRay( iPhoneInput.GetTouch(0).position );

            RaycastHit hit;

            if( collider.Raycast( cursorRay, out hit, 1000.0f ) ) 

            {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0);
            }
			}
        }	
	}
}
