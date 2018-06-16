using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : Stuff {

	public  RodScript rodbool;
	public bool KeyBool = false;

	public override void OnClickDown ()
	{
		base.OnClickDown ();
		//Debug.Log ("鍵だ");
		if (rodbool.RodBool) {
			Debug.Log ("「棒を使って鍵を入手した」");
			KeyBool = true;
			Destroy (this.gameObject);
		} else {
			Debug.Log ("「鍵に手が届かない」");
			Debug.Log ("「何か長い物があれば取れそうだ」");
		}
	}
}
