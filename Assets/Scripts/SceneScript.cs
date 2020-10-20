using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SceneScript : MonoBehaviour
{
    public Camera viewCam;
    public Camera drawerCam;
    public Camera cabinetCam;

    // Start is called before the first frame update
    void Start()
    {
        viewCam.enabled = true;
        drawerCam.enabled = false;
        cabinetCam.enabled = false;

        viewCam.GetComponent<CameraController>().setView(cabinetCam.transform, 0.15f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
