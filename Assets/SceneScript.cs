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

        //GameObject.Find("objectPanel").SetActive(false);
        //Debug.Log("Panel is active : " + GameObject.Find("objectPanel").activeInHierarchy);

        viewCam.GetComponent<CameraController>().setView(cabinetCam.transform);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
