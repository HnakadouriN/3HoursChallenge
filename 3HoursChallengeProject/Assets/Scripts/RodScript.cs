using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodScript : Stuff {

	public bool RodBool = false;

	public override void OnClickDown()
	{
		base.OnClickDown ();
		MyDebug.LogOnText ("「長い棒を入手した　何かに使えそうだ」", 2f);
		RodBool = true;
		Destroy (this.gameObject);
	}

}
