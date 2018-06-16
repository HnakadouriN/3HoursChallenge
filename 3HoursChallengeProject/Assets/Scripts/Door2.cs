using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door2 : Door
{
    public override void OnClickDown()
    {
        base.OnClickDown();
        MoveRoom("Result");
    }
}
