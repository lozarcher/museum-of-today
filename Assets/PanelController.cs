using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    private bool visible;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleVisibility()
    {
        this.visible = !visible;
        Debug.Log("Panel is visible: " + visible);
    }
}
