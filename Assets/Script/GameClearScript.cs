using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameClearScript : MonoBehaviour {


	void Start () {
		this.gameObject.GetComponent<Text> ().enabled = false;

	}

	public void Win(){
		gameObject.GetComponent<Text> ().enabled = true;
	}
		
	void Update () {

	}
}
