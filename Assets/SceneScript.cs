using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneScript : MonoBehaviour
{
    public Camera viewCam;
    public Camera drawerCam;
    public Camera cabinetCam;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started scene script 2!");
        viewCam.enabled = true;
        drawerCam.enabled = false;
        cabinetCam.enabled = false;

        viewCam.GetComponent<CameraController>().setView(cabinetCam.transform);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
