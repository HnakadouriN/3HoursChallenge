using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public static Text msgWindow;
    public static PlayerController playerController;
    
    private GameObject mainCamera;
    private Stuff LookingStuff;
    private Stuff ClickedStuff;
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
        if (Input.GetMouseButtonDown(0))
        {
            OnClickDown();
        }
        if (Input.GetMouseButtonUp(0))
        {
            OnClickUp();
        }
        if (Input.GetMouseButton(0))
        {
            OnClick();
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
                OnHover();
            }
        }
        else {
            if (LookingObjID != 0) {
                OnHoverUp();
            }
            LookingStuff = stuff;
            LookingObjID = ID;
            if (ID != 0)
            {
                OnHoverDown();
            }
        }
    }
    private void OnClickDown() {
        if (!LookingStuff) return;
        LookingStuff.OnClickDown();
        ClickedStuff = LookingStuff;
    }
    private void OnClick() {
        if (!ClickedStuff) return;
        ClickedStuff.OnClick();
    }
    private void OnClickUp() {
        if (!ClickedStuff) return;
        ClickedStuff.OnClickUp();
        ClickedStuff = null;
    }
    private void OnHoverDown() {
        LookingStuff.OnHoverDown();
    }
    private void OnHover() {
        LookingStuff.OnHover();
    }
    private void OnHoverUp() {
        LookingStuff.OnHoverUp();
    }
}