using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class AkritiScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MenuCanvasGo, InstaCanvasGo, VideoPlaneGo, InstaBtn;
    VirtualButtonBehaviour[] vrb;
    void Start()
    {
        MenuCanvasGo.SetActive(false);
        InstaCanvasGo.SetActive(false);
        VideoPlaneGo.SetActive(false);
        vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterOnButtonPressed(onButtonPressed);
            vrb[i].RegisterOnButtonReleased(onButtonReleased);

        }
    }

    // Update is called once per frame
    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "Menu")
        {
            MenuCanvasGo.SetActive(true);
            InstaCanvasGo.SetActive(false);
            VideoPlaneGo.SetActive(false);

        }
        else if (vb.VirtualButtonName == "instagram")
        {
            MenuCanvasGo.SetActive(false);
            InstaCanvasGo.SetActive(true);
            VideoPlaneGo.SetActive(false);

        }
        else if (vb.VirtualButtonName == "Icon")
        {
            MenuCanvasGo.SetActive(false);
            InstaCanvasGo.SetActive(false);
            VideoPlaneGo.SetActive(true);
            InstaBtn.SetActive(false);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "not supported");
        }
    }
    public void onButtonReleased(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "Icon")
        {
            MenuCanvasGo.SetActive(false);
            InstaCanvasGo.SetActive(false);
            VideoPlaneGo.SetActive(false);
        }
        Debug.Log("released");
    }
}
