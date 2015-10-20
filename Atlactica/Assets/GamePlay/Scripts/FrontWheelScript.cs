using UnityEngine;
using System.Collections;

public class FrontWheelScript : MonoBehaviour {

	public static bool touchingTerrain_frontWheel;
	public bool test;
	void OnTriggerEnter(Collider obj)
	{
		if (obj.gameObject.name == "MeshPiece") {
			touchingTerrain_frontWheel = true;
			test = true;
		}
	}

	void OnTriggerStay(Collider obj)
	{
		if (obj.gameObject.name == "MeshPiece") {
			touchingTerrain_frontWheel = true;
			test = true;
		}
	}

	void OnTriggerExit(Collider obj)
	{
		if (obj.gameObject.name == "MeshPiece") {
			touchingTerrain_frontWheel = false;
			test = false;
		}

	}

}
