using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class pbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Plane, Picplane, Canvas;
    VirtualButtonBehaviour[] vrb;
    void Start()
    {
        Plane.SetActive(false);
        Picplane.SetActive(false);
        Canvas.SetActive(false);
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
        if (vb.VirtualButtonName == "photo")
        {
            Plane.SetActive(false);
            Picplane.SetActive(true);
            Canvas.SetActive(false);

        }
        else if (vb.VirtualButtonName == "df")
        {
            Plane.SetActive(true);
            Picplane.SetActive(false);
            Canvas.SetActive(false);

        }
        else if (vb.VirtualButtonName == "phone")
        {
            Plane.SetActive(false);
            Picplane.SetActive(false);
            Canvas.SetActive(true);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "not supported");
        }
    }
    public void onButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("released");
    }
}
