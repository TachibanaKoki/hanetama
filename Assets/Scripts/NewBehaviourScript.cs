using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision col){
		if (col.collider.tag == "ball") {
			GameManager.scenenumber--;
			Pinpon.isShot=false;
			Application.LoadLevel(Application.loadedLevelName);
		}
	}
}
