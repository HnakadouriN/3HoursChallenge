using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {

    public static bool door1IsLocked = true;
    public static bool door2IsLocked = true;
    public static bool door3IsLocked = true;
    public static bool door4IsLocked = true;
    public static bool result = true;

    public static bool IsLocked(string doorName)
    {
        switch (doorName)
        {
            case "door1": return door1IsLocked;
            case "door2": return door2IsLocked;
            case "door3": return door3IsLocked;
            case "door4": return door4IsLocked;
            case "result": return result;
        }

        return false;
    }
    public static void Unlock(string doorName)
    {
        switch (doorName)
        {
            case "door1": door1IsLocked = false;break;
            case "door2": door2IsLocked = false;break;
            case "door3": door3IsLocked = false;break;
            case "door4": door4IsLocked  =false;break;
            case "result": result = false;break;
        }
    }

    public static void Reset()
    {
        door1IsLocked = true;
        door2IsLocked = true;
        door3IsLocked = true;
        door4IsLocked = true;
        result = true;
    }
}
