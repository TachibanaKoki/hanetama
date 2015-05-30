using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	static public bool ClearFlag=false;
	public Text cleartext;
	public GameObject button;
	static public int scenenumber=0;

	public void Reset()
	{
		if (Pinpon.isShot==true) {
			Pinpon.isShot = false;
			scenenumber-=1;
			Application.LoadLevel (Application.loadedLevelName);
		}
	}

	public void Exit()
	{
		Application.Quit ();
	}

	public void NextScene(){
		Pinpon.isShot = false;
		Application.LoadLevel ("main "+(scenenumber));
	}
	public void ReTitle(){
		scenenumber = 0;
		Pinpon.isShot = false;
		Application.LoadLevel ("taitle");
	}


	// Use this for initialization
	void Start () {
		ClearFlag = false;
		scenenumber++;
	}
	
	// Update is called once per frame
	void Update () {
		if (ClearFlag == true) {
			cleartext.enabled=true;
			button.SetActive(true);
		}
	}
}
