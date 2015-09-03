using UnityEngine;
using System.Collections;

public class LightTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//when the player walks into the trigger on this gameobject
	void OnTriggerEnter(Collider other) {
		Debug.Log ("The Trigger is working");
		//get the light component on this gameobject, turn it off
		gameObject.GetComponent<Light>().enabled = false; 
	}

	void OnTriggerExit(Collider other) {
		Debug.Log ("Trigger exit is working");
		gameObject.GetComponent<Light>().enabled = true;
	}

}