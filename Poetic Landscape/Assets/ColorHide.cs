using UnityEngine;
using System.Collections;

public class ColorHide : MonoBehaviour {
	

	void OnTriggerEnter() {
			gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;

			GameObject.Find ("BigCube").SetActive(false);

	}
}
