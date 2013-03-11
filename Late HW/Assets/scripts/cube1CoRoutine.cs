using UnityEngine;
using System.Collections;

public class cube1CoRoutine : MonoBehaviour {
	
	public float speed = 2f;
	public float rotationCube = 2f;

	// Use this for initialization
	void Start () {
		
		StartCoroutine (Movie());
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	IEnumerator Movie (){
		
		while(true){
			
		transform.position += new Vector3 (0f, -speed, 0f) * Time.deltaTime; 
		
		transform.localScale += new Vector3 (0f, -speed, 0f) * Time.deltaTime;
			
		transform.Rotate (new Vector3 (0f, 0f, rotationCube)*Time.deltaTime);

		yield return new WaitForSeconds(0f);
			
		}
			
	}
}
