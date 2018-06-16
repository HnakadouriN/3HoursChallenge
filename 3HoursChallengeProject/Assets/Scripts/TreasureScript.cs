using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureScript : Stuff {

	public KeyScript keybool;

	public override void OnClickDown ()
	{
		base.OnClickDown ();
		if (keybool.KeyBool) {
			Debug.Log ("「鍵を使って箱を開けた」");
			Debug.Log ("「中から紙が出てきた」");
			Debug.Log ("「● ● ３ ４」");
			Destroy (this.gameObject);
		} else {
			Debug.Log ("「鍵が掛かっていて開かない」");
		}
	}
}
