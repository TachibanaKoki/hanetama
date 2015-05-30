using UnityEngine;
using System.Collections;

public class goal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if (col.collider.tag == "ball") {
			GameManager.ClearFlag=true;
			Debug.Log("clear");
		}
	}
}
