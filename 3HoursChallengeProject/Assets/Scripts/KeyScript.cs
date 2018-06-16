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
			MyDebug.LogOnText ("「棒を使って鍵を入手した」", 2f);
			KeyBool = true;
			Destroy (this.gameObject);
		} else {
            StartCoroutine(Msg());
		}
	}

    IEnumerator Msg()
    {
        MyDebug.LogOnText("「鍵に手が届かない」");
        yield return new WaitForSeconds(2f);
        MyDebug.LogOnText("「何か長い物があれば取れそうだ」", 2f);
    }
}
