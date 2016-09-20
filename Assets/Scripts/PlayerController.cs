using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			transform.position += new Vector3 (moveSpeed * -1f, 0f, 0f);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (moveSpeed, 0f, 0f);
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.position += new Vector3 (0f, 0f, moveSpeed);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position += new Vector3 (0f, 0f, moveSpeed * -1f);
		}
		Camera.main.transform.position = transform.position + new Vector3 (0f, 5f, -6f);
	}
}




