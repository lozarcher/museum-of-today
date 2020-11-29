using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectEvent : MonoBehaviour
{

    private GameObject cabinetObject;
    private PopupMessage popupMessage;
    private static float movementTransitionSpeed = 1f;
    private static float scaleTransitionSpeed = 0.05f;

    private static float raiseAmount = 0.05f;

    private static float scaleAmount = 1.1f;
    private Vector3 targetScale;
    private static Vector3 originalScale = new Vector3(1.0f, 1.0f, 1.0f);

    private float targetY, originalY;
    private bool objectFloating = false;

    // Start is called before the first frame update
    void Start()
    {
        cabinetObject = GameObject.Find("cabinetObject");
        popupMessage = cabinetObject.GetComponent<PopupMessage>();
        targetY = transform.position.y;
        originalY = transform.position.y;
        targetScale = originalScale;
    }



    void OnMouseDown()
    {
        Debug.Log(this.gameObject.name + " object was selected - on mouse down");

        if (!popupMessage.IsActive()) {
            popupMessage.OpenAsync("You clicked " + this.gameObject.name, this.gameObject.name);
        }

    }

    void OnMouseOver()
    {
        GameObject thisObject = this.gameObject;
        MeshRenderer meshRenderer = thisObject.GetComponent<MeshRenderer>();
        if (!objectFloating)
        {
            targetY = originalY + raiseAmount;
            targetScale = new Vector3(scaleAmount, 1.0f, scaleAmount);
            objectFloating = true;
        }

    }
    void OnMouseExit()
    {
        GameObject thisObject = this.gameObject;
        MeshRenderer meshRenderer = thisObject.GetComponent<MeshRenderer>();
        if (objectFloating)
        {
            targetY = originalY;
            targetScale = originalScale;

            objectFloating = false;
        }
    }

    void LateUpdate()
    {
         transform.position =
            Vector3.Lerp(
                new Vector3(transform.position.x, transform.position.y, transform.position.z),
                new Vector3(transform.position.x, targetY, transform.position.z),
                Time.deltaTime * movementTransitionSpeed);

        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, scaleTransitionSpeed);

    }

}
