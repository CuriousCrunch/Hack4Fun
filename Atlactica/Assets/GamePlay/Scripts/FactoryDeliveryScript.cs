using UnityEngine;
using System.Collections;

public class FactoryDeliveryScript : MonoBehaviour {

	public GameObject[] crates;
	Vector3 position;
	Quaternion rotation;
	GameObject temp, destroyAllCrates;
	public GameObject allCrates;
	// Use this for initialization
	void Start () {
		destroyAllCrates = GameObject.FindGameObjectWithTag("Crates");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider obj)
	{
		if (obj.gameObject.tag == "Truck") {
			Debug.Log ("collided");
			Time.timeScale = 0;
			for(int i=7; i>=0; i--)
			{
				if(!GameObject.Find("Crate (" + i + ")"))
				{
					obj.GetComponent<Rigidbody>().isKinematic = true;
					position = obj.transform.position;
					position.x += 2;
					position.y += 1;

					destroyAllCrates = GameObject.FindWithTag("Crates");
					Destroy(destroyAllCrates);
					temp = Instantiate(allCrates);
					temp.gameObject.tag = "Crates";
					temp.transform.parent = obj.gameObject.transform;
					temp.transform.localScale = new Vector3(1, 1, 1);
					temp.transform.position = position;

					obj.GetComponent<Rigidbody>().isKinematic = false;
					//obj.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);

				}
			}



//			position = obj.transform.position;
//			rotation = obj.transform.rotation;
//			position.x += 50;
//			Destroy (obj.gameObject);
//			Instantiate(truck, position, rotation);
			Time.timeScale = 1;
		}
	}
}
