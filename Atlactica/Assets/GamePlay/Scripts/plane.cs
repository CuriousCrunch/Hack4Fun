using UnityEngine;
using System.Collections;

public class plane : MonoBehaviour {

	public GameObject pos1, pos2;
	float speed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, pos2.transform.position, step);
	}
}
