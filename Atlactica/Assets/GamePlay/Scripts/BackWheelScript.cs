using UnityEngine;
using System.Collections;

public class BackWheelScript : MonoBehaviour {

	public static bool touchingTerrain_backWheel;
	public bool test;

	void OnTriggerEnter(Collider obj)
	{    
		if (obj.gameObject.name == "MeshPiece") {
			touchingTerrain_backWheel = true;
			test = true;
		}
	}

	void OnTriggerStay(Collider obj)
	{    
		if (obj.gameObject.name == "MeshPiece") {
			touchingTerrain_backWheel = true;
			test = true;
		}
	}

	void OnTriggerExit(Collider obj)
	{
		if (obj.gameObject.name == "MeshPiece") {
			touchingTerrain_backWheel = false;
			test = false;
		}
	}
}
