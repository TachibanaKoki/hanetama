using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pinpon : MonoBehaviour {
	public Vector3 power= new Vector3 (-600,0,0);

	private Rigidbody body;
	private Ray ray;
	private RaycastHit hit;
	private Text text;
	static public  bool isShot=false;
	// Use this for initialization
	void Start () {
		body = gameObject.GetComponent<Rigidbody> ();
		text = GameObject.Find ("resettext").GetComponent<Text>();
		isShot=false;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Shot(){
		if (isShot==false) {
			body.AddForce (power);
			body.useGravity = true;
			isShot = true;
			text.text="RETRY";
		}
	}
}
