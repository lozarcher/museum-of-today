﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectEvent : MonoBehaviour
{

    private GameObject cabinetObject;
    private PopupMessage popupMessage;

    // Start is called before the first frame update
    void Start()
    {
        cabinetObject = GameObject.Find("cabinetObject");
        popupMessage = cabinetObject.GetComponent<PopupMessage>();

    }



    void OnMouseDown()
    {
        Debug.Log(this.gameObject.name + " object was selected - on mouse down");

        if (!popupMessage.IsActive()) {
            popupMessage.OpenAsync("You clicked " + this.gameObject.name, this.gameObject.name);
        }
        //PanelController panelController = GameObject.Find("objectPanel").GetComponent<PanelController>();
        //panelController.toggleVisibility();
        //GameObject.Find("objectPanel").SetActive(true);
        //Debug.Log("Panel is active : "+GameObject.Find("objectPanel").activeInHierarchy);

    }

    void OnMouseOver()
    {
        GameObject thisObject = this.gameObject;
        MeshRenderer meshRenderer = thisObject.GetComponent<MeshRenderer>();
        meshRenderer.receiveShadows = false;
    }
    void OnMouseExit()
    {
        GameObject thisObject = this.gameObject;
        MeshRenderer meshRenderer = thisObject.GetComponent<MeshRenderer>();
        meshRenderer.receiveShadows = true;
    }

    void Update()
    {
    }

    private void LateUpdate()
    {
        
    }

}
