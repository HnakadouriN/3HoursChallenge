using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public static Text msgWindow;
    public static PlayerController playerController;
    
    private GameObject mainCamera;
    private Stuff LookingStuff;
    private int LookingObjID = 0;
    // Use this for initialization
    void Start()
    {
        playerController = this;
        msgWindow = GameObject.Find("Player/Canvas/MsgText").GetComponent<Text>();
        
        mainCamera = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        GetStuff();
        if (!LookingStuff) {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            LookingStuff.OnClickDown();
        }
        if (Input.GetMouseButtonUp(0))
        {
            LookingStuff.OnClickUp();
        }
        if (Input.GetMouseButton(0))
        {
            LookingStuff.OnClick();
        }
    }
    private void GetStuff() {
        Ray ray = new Ray(mainCamera.transform.position, mainCamera.transform.forward);
        RaycastHit hit;
        Stuff hitStuff = null;
        if (Physics.Raycast(ray, out hit))
        {
            hitStuff = hit.collider.gameObject.GetComponent<Stuff>();
        }
        CheckID(hitStuff);
    }
    private void CheckID(Stuff stuff) {
        int ID = 0;
        if (stuff) {
            ID = stuff.GetInstanceID();
        }
        if (ID == LookingObjID)
        {
            if (LookingObjID != 0)
            {
                LookingStuff.OnHover();
            }
        }
        else {
            if (LookingObjID != 0) {
                LookingStuff.OnHoverUp();
            }
            if (ID != 0)
            {
                stuff.OnHoverDown();
            }
            LookingObjID = ID;
            LookingStuff = stuff;
        }
    }
}