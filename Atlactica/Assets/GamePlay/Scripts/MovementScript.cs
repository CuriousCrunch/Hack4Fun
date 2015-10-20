using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	public int speed;
	public float rpm;
	public GameObject  backWheel, frontWheel;
	GameObject truck;
	bool moveRight;
    Rigidbody truckRigidbody;

    public Camera playerCamera;

	// Use this for initialization
	void Start () {
		if (playerCamera == null)
		{
			playerCamera = Camera.main;
		}
		playerCamera.transparencySortMode = TransparencySortMode.Orthographic;
		truck = GameObject.FindGameObjectWithTag ("Truck");
        truckRigidbody = truck.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
//		if (!truck) {
//			truck = GameObject.FindGameObjectWithTag ("Truck");
//			truckRigidbody = truck.GetComponent<Rigidbody>();
//		}
		if (moveRight && (BackWheelScript.touchingTerrain_backWheel)) {
            //truck.transform.Translate(Vector3.right * speed * Time.deltaTime);

			if (truckRigidbody.velocity.x < 50)
                truckRigidbody.AddForce(Vector3.right * 80, ForceMode.Acceleration);

            backWheel.transform.Rotate(0, 0, -6.0f * rpm * Time.deltaTime);
			frontWheel.transform.Rotate(0, 0, -6.0f * rpm * Time.deltaTime);
		}
		playerCamera.transform.position = new Vector3(truck.transform.position.x, truck.transform.position.y + 10, playerCamera.transform.position.z);

	}


	public void clickButton(bool val)
	{
		moveRight = val;
	}

}
