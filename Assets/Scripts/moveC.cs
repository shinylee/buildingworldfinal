using UnityEngine;
using System.Collections;

public class moveC : MonoBehaviour {

	public float moveSpeed = 5;
	public float turnSpeed = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Rotate(0, turnSpeed, 0) ;
		}
		
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Rotate(0, -turnSpeed, 0) ;
		}
	
	}
}
