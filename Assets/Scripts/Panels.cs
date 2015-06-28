using UnityEngine;
using System.Collections;

public class Panels : MonoBehaviour {
	private Vector3 screenPoint;
	private Vector3 offset;
	void OnMouseDown()
	{
		if (Pinpon.isShot == false)
		{
			//カメラから見たオブジェクトの現在位置を画面位置座標に変換
			screenPoint = Camera.main.WorldToScreenPoint (transform.position);
		
			//取得したscreenPointの値を変数に格納
			float x = Input.mousePosition.x;
			float y = Input.mousePosition.y;
		

			offset = transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (x, y, screenPoint.z));
		}
	}
	
	void OnMouseDrag()
	{
		if (Pinpon.isShot == false)
		{
			//ドラッグ時のマウス位置を変数に格納
			float x = Input.mousePosition.x;
			float y = Input.mousePosition.y;
		
			Debug.Log (x.ToString () + " - " + y.ToString ());
		
			//ドラッグ時のマウス位置をシーン上の3D空間の座標に変換する
			Vector3 currentScreenPoint = new Vector3 (x, y, screenPoint.z);
		
			//上記にクリックした場所の差を足すことによって、オブジェクトを移動する座標位置を求める
			Vector3 currentPosition = Camera.main.ScreenToWorldPoint (currentScreenPoint) + offset;
		
			//オブジェクトの位置を変更する
			transform.position = currentPosition;
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
