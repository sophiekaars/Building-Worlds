using UnityEngine;
using System.Collections;

public class flyingCubes : MonoBehaviour {
	
	public float speed = 2f;
	public float distance = 2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position += new Vector3 (0f, -speed, 0f) * Time.deltaTime; 
		
		transform.Rotate (new Vector3 (0f, 0f, 10f) * Time.deltaTime);
	}
}
