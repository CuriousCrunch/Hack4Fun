using UnityEngine;
using System.Collections;

public class ReverseScript : MonoBehaviour {
	
	public int speed;
	public float rpm;
	public GameObject backWheel, frontWheel;
	GameObject truck;
	bool moveLeft;
    Rigidbody truckRigidbody;
	// Use this for initialization
	void Start () {
		truck = GameObject.FindGameObjectWithTag ("Truck");
        truckRigidbody = truck.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
//		if (!truck) {
//			truck = GameObject.FindGameObjectWithTag ("Truck");
//			truckRigidbody = truck.GetComponent<Rigidbody>();
//		}
		if (moveLeft && (FrontWheelScript.touchingTerrain_frontWheel || BackWheelScript.touchingTerrain_backWheel)) {
            //truck.transform.Translate(Vector3.left * speed * Time.deltaTime);

            if (truckRigidbody.velocity.x < 20)
                truckRigidbody.AddForce(Vector3.left * 60, ForceMode.Acceleration);

			backWheel.transform.Rotate(0, 0, 6.0f * rpm * Time.deltaTime);
			frontWheel.transform.Rotate(0, 0, 6.0f * rpm * Time.deltaTime);
		}
	}
	
	public void clickButton(bool val)
	{
		moveLeft = val;
	}
	
}
