using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperScript : Stuff {

	public override void OnClickDown ()
	{
		base.OnClickDown ();
		Debug.Log ("「紙に何か書いてある」");
		Debug.Log ("「1 ２ ● ●」");
		Debug.Log ("「所々かすれていて文字が読めない」");
	}
}
