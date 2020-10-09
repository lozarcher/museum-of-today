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
    }


    void Update()
    {
    }

    private void LateUpdate()
    {
        
    }

}
