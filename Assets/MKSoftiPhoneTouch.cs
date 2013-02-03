using UnityEngine;
using System.Collections;

public class MKSoftiPhoneTouch : MonoBehaviour {
	
	public float speed = 1f;
	public GameObject box;
	public bool boxactive = false;
	public int count;

	void Awake()
	{
		box = this.gameObject;
	}
	
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		boxactivate();
		if(boxactive == true)
			if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0);
		}
	}
	
	
	void boxactivate()
	{
		if(Input.touchCount > 0 && boxactive == false)
		{
			boxactive = true;
		}
	}
}
