using UnityEngine;
using System.Collections;

public class trampoline : MonoBehaviour {
	
	public Vector3 Power = new Vector3 (0,10,0);
	public Rigidbody rig;
	
	// Use this for initialization
	void Start () {
		rig = GameObject.Find ("Pinpon").GetComponent<Rigidbody> ();
	}

	void OnCollisionEnter(Collision col){
		
		if (col.collider.tag == "ball") {
			rig.AddForce(Power);
		}
	}


}
