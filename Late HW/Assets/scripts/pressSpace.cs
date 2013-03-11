using UnityEngine;
using System.Collections;

public class pressSpace : MonoBehaviour {
	
	public GUIText referencetotext;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider hit){
	referencetotext.text = "press Space";	
	}
	
	void OnTriggerExit(Collider hit){
	referencetotext.text = "";	
	}
}
