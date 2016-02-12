using UnityEngine;
using System.Collections;

public class BlockContoroller : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		
		Destroy (gameObject);
	}
}
