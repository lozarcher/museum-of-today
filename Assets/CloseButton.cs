using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class CloseButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("CLOSE pressed");
        GameObject cabinetObject = GameObject.Find("cabinetObject");
        PopupMessage popupMessage = cabinetObject.GetComponent<PopupMessage>();

        popupMessage.Close();
    }
}
