using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MyDebug {

	public static void LogOnText(string msg)
    {
        PlayerController.playerController.StopCoroutine("DelayMethod");
        Debug.Log(msg);

        if (!PlayerController.msgWindow) return;

        PlayerController.msgWindow.text = msg;
    }
    public static void LogOnText(string msg, float displayTime)
    {
        LogOnText(msg);
        PlayerController.playerController.StartCoroutine(DelayMethod(displayTime, () => { PlayerController.msgWindow.text = ""; }));
    }

    static IEnumerator DelayMethod(float delayTime, Action action)
    {
        yield return new WaitForSeconds(delayTime);
        action();
    }
}
