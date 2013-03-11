using UnityEngine;
using System.Collections;

public class fontColour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		renderer.material.color = Color.black;
		
		transform.position += (-transform.forward * Time.deltaTime)*5;
	
	}
}
