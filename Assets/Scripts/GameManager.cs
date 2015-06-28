using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	static public bool ClearFlag=false;
	public Text cleartext;
	public GameObject button;

	static public int scenenumber=0;

	private bool opAnim;//スタート時のアニメーションフラグ
	private static bool animcheck=false;//新しいシーンの読み込み時にアニメーションをさせる
	private float timecount;
	private Pinpon pinpon;


	public void Reset()
	{
		//弾の発射フラグが立っていればリセット
		if (Pinpon.isShot) {
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
		//次のシーンを読み込み
		Application.LoadLevel ("main "+(scenenumber));
	}
	public void ReTitle(){
		scenenumber = 0;
		Pinpon.isShot = false;
		//タイトルに飛ぶ
		Application.LoadLevel ("taitle");
	}


	// Use this for initialization
	void Start () {
		//読み込み時、次に備えてシーンのナンバーをインクリメント
		ClearFlag = false;
		//reset時はアニメーションをしない
		if (!animcheck)
			opAnim = true;
		else
			opAnim = false;
		timecount = 0;

		scenenumber++;

	}
	
	// Update is called once per frame
	void Update () {

		//オープニングアニメーション中か
		if (opAnim) {
			//弾を発射。startにいるとGameObjectが見えないっぽいのでここで初期化
			if (timecount == 0.0f) {
				Pinpon.isShot = false;
				pinpon = GameObject.Find ("Pinpon").GetComponent<Pinpon>();
				pinpon.Shot();
			}
			//開始から数秒でアニメーションを終了させる
			timecount+=Time.deltaTime;
			if(timecount>3.0f){
				opAnim=false;
				pinpon.PosReset();
			}
			return;
		}

		//クリアしているか
		if (ClearFlag == true) {
			cleartext.enabled=true;
			button.SetActive(true);
		}
	}
}
