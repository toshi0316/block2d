using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public GameObject gameClear;
	int speed = 5;
	public int blockCt = 20;
	Rigidbody rb;
	Vector3 v;

	void Start(){

		rb = GetComponent<Rigidbody>();
		rb.AddForce((transform.up + transform.right) * speed, ForceMode.VelocityChange);
	}
	void Update(){

		if (blockCt == 0) {
			GetComponent<Rigidbody> ().velocity = Vector3.zero;
			gameClear.SendMessage ("Win");
			if (Input.GetMouseButtonDown (0)) {
				Application.LoadLevel ("title");
			}
		}
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Block") {
			blockCt -= 1;
		}
	}
}
