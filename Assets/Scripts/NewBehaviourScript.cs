using UnityEngine;
using System.Collections;
/// <summary>
///接触したらやり直し 
/// </summary>
public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision col){
		//ボールに当たればシーンをリセット
		if (col.collider.tag == "ball") {
			GameManager.scenenumber--;
			Pinpon.isShot=false;
			Application.LoadLevel(Application.loadedLevelName);
		}
	}
}
