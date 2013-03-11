using UnityEngine;
using System.Collections;

public class growingFallingCube : MonoBehaviour {
	
	public float speed = 2f;
	public float distance = 2f;

	// Use this for initialization
	void Start () {
		
		StartCoroutine (Movie());
	
	}
	
	// Update is called once per frame
	void Update () {
		
//		transform.position += new Vector3 (0f, -speed, 0f) * Time.deltaTime; 
//		transform.localScale += new Vector3 (0f, -speed, 0f) * Time.deltaTime;
	
	}
	
	IEnumerator Movie (){
		
		while(true){
			
		transform.position += new Vector3 (0f, -speed, 0f) * Time.deltaTime; 
		
		transform.localScale += new Vector3 (0f, -speed, 0f) * Time.deltaTime;
			
		transform.position += new Vector3 (0f, Mathf.Sin(Time.time * speed), 0f) *Time.deltaTime * distance;

		yield return new WaitForSeconds(0f);
			
		}
			
	}
}
