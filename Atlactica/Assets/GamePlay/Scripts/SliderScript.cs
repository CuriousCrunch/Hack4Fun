using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {
	
	private Slider slider;
	private int counter;
	float start;
	public Image Fill;
	bool flagT;

	public GameObject gameOverPanel, menuPanel, playPanel;

	// Use this for initialization
	void Start () {
		start = (int)Time.time;

		slider = gameObject.GetComponent<Slider>();
		slider.value = 100;

	
	}
	
	// Update is called once per frame
	void Update () {

		counter = (int)(Time.time - start);


		Debug.Log (slider.value);
		slider.value = (int)(100 - (counter*0.7 )); 

		if (slider.value < 2) {
			menuPanel.SetActive(false);
			playPanel.SetActive(false);
			gameOverPanel.SetActive(true);
		}

		for(int i=7; i>=0; i--)
		{
			if(!GameObject.Find("Crate (" + i + ")"))
				flagT=true;
			else
				flagT=false;
		}
		if(flagT)
		{
			menuPanel.SetActive(false);
			playPanel.SetActive(false);
			gameOverPanel.SetActive(true);
		}

		if (slider.value > 80) {
			Fill.color = Color.red;

		} else if (slider.value > 60 && slider.value < 80) {
			Debug.Log ("less than 80");
			Fill.color = Color.magenta;
		} else if (slider.value < 60 && slider.value > 40) {
			Fill.color = Color.yellow;
		}
		else if (slider.value < 40 && slider.value > 20) {
			Fill.color =Color.blue;
		}
		else if (slider.value < 20) {
			Fill.color =Color.black;
		}

	}
}
