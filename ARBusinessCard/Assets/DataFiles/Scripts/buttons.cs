using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class buttons : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject developerGO, trainerGO, travellerGO;
    VirtualButtonBehaviour[] vrb;
    void Start()
    {
        developerGO.SetActive(false);
        trainerGO.SetActive(false);
        travellerGO.SetActive(false);
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
            developerGO.SetActive(true);
            trainerGO.SetActive(false);
            travellerGO.SetActive(false);

        }
        else if (vb.VirtualButtonName == "df")
        {
            developerGO.SetActive(false);
            trainerGO.SetActive(true);
            travellerGO.SetActive(false);

        }
        else if (vb.VirtualButtonName == "phone")
        {
            developerGO.SetActive(false);
            trainerGO.SetActive(false);
            travellerGO.SetActive(true);
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
