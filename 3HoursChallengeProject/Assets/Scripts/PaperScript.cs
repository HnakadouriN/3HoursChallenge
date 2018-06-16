using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperScript : Stuff {

	public override void OnClickDown ()
	{
		base.OnClickDown ();
        StartCoroutine(Msg());
	}

    IEnumerator Msg()
    {
        MyDebug.LogOnText("「紙に何か書いてある」");
        yield return new WaitForSeconds(2f);
        MyDebug.LogOnText("「4 ２ ● ●」");
        yield return new WaitForSeconds(3f);
        MyDebug.LogOnText("「所々かすれていて文字が読めない」", 2f);
    }
}
