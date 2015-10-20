using UnityEngine;
using System.Collections;

public class PanelLinking : MonoBehaviour {

	public GameObject menucanvas;
	public GameObject playcanvas;
	public GameObject pausepanel;
	public GameObject toppanel;
	public GameObject buttonpanel;

	public void playclicked(){
		menucanvas.SetActive (false);
		playcanvas.SetActive (true);
	}

	public void pauseclicked(){
		toppanel.SetActive (false);
		buttonpanel.SetActive (false);
		pausepanel.SetActive (true);
		Time.timeScale = 0;
	}

	public void homeclicked(){
		Time.timeScale = 1;
		Application.LoadLevel (0);
	}

	public void resumeclicked(){
		pausepanel.SetActive (false);
		toppanel.SetActive (true);
		buttonpanel.SetActive (true);
		Time.timeScale = 1;
	}


}
