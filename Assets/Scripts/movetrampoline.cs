using UnityEngine;
using System.Collections;
/// <summary>
/// Movetrampoline.
/// 動いて弾が強力に反射する
/// </summary>
public class movetrampoline : MonoBehaviour {

	
	public Vector3 movevec=new Vector3(10,0,0);
	public Vector3 maxmove=new Vector3(300,0,0);
	public Vector3 Power = new Vector3 (0,10,0);
	private bool RorL=true;
	public Rigidbody rig;
	
	// Use this for initialization
	void Start () {
		rig = GameObject.Find ("Pinpon").GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		//右に移動しているなら
		if (RorL) {
			this.transform.position+=movevec;
			if(this.transform.position.x>maxmove.x){
				RorL=false;
			}
		} 
		//左に移動しているなら
		else {
			this.transform.position-=movevec;
			if(this.transform.position.x<-maxmove.x){
				RorL=true;
			}
		}
	}
	void OnCollisionEnter(Collision col){
		
		if (col.collider.tag == "ball") {
			rig.AddForce(Power);
		}
	}

}
