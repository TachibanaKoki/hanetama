using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pinpon : MonoBehaviour {
	public Vector3 power= new Vector3 (-600,0,0);

	private Rigidbody body;
	private Ray ray;
	private RaycastHit hit;
	private Text text;
	private Vector3 statePos;
	static public  bool isShot=false;
	// Use this for initialization
	void Start () {
		body = this.GetComponent<Rigidbody> ();
		text = GameObject.Find ("resettext").GetComponent<Text>();
		statePos = this.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void PosReset(){
		body.useGravity = false;
		body.velocity = Vector3.zero;
		Pinpon.isShot = false;
		text.text="SHOT!";
		this.gameObject.transform.position = statePos;
	}

	public void Shot(){
		//弾が発射されていなければ発射する
		if (Pinpon.isShot==false) {
			body.AddForce (power);
			body.useGravity = true;
			Pinpon.isShot = true;
			text.text="RETRY";
		}
	}
}
