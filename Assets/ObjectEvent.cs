using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {    }

    void OnMouseDown()
    {
        Debug.Log(this.gameObject.name + " object was selected - on mouse down");


        //PanelController panelController = GameObject.Find("objectPanel").GetComponent<PanelController>();
        //panelController.toggleVisibility();
        //GameObject.Find("objectPanel").SetActive(true);
        //Debug.Log("Panel is active : "+GameObject.Find("objectPanel").activeInHierarchy);

    }


    void Update()
    {
    }

    private void LateUpdate()
    {
        
    }

}
