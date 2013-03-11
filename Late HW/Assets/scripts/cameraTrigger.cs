using UnityEngine;
using System.Collections;

public class cameraTrigger : MonoBehaviour {
	
	public Camera camera1;
	public Camera camera2;
	public Camera camera3;
	
	

	// Use this for initialization
	void Start () {
	
		camera1.enabled = true;
		camera2.enabled = false;
		camera3.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyUp(KeyCode.Space)){
		camera1.enabled = false;
		camera2.enabled = true;
		camera3.enabled = false;
		}
		
		if(Input.GetKeyUp(KeyCode.Return)){
		camera1.enabled = false;
		camera2.enabled = false;
		camera3.enabled = true;
		}
	}
	
	
	}
	

