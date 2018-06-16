using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureScript : Stuff {

	public KeyScript keybool;

	public override void OnClickDown ()
	{
		base.OnClickDown ();
		if (keybool.KeyBool) {
            StartCoroutine(Msg());
			Destroy (this.gameObject,7f);
		} else {
			MyDebug.LogOnText ("「鍵が掛かっていて開かない」", 2f);
		}
	}
    IEnumerator Msg()
    {
        MyDebug.LogOnText("「鍵を使って箱を開けた」");
        yield return new WaitForSeconds(2f);
        MyDebug.LogOnText("「中から紙が出てきた」");
        yield return new WaitForSeconds(2f);
        MyDebug.LogOnText("「● ● 1 0」", 3f);
    }
}
