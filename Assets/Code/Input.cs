using UnityEngine;
using System.Collections;


public class Input : MonoBehaviour {

	public string Status;

	// Use this for initialization
	void Start () {
		Debug.Log ("Hello");
	}
	
	// Update is called once per frame

	void Update () {
		//var a = GetComponent ();
		var canon = gameObject;
		canon.transform.Translate (new Vector3 (0.01f, 0.01f, 0.00f));

	}


void OnGUI() {
		GUILayout.Label ( Status );
	}

}
