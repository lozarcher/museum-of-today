using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColliderScript : MonoBehaviour
{
    public Camera targetCam;
    public Camera viewCam;
    public Camera cabinetCam;
    private bool activeMovement = false;

    private bool isZoomed;

    private Vector3 targetPosition;
    private float Zmovement = -0.5f;

    // Start is called before the first frame update
    void Start()
    {
        isZoomed = false;
        targetPosition = transform.position;
    }

    IEnumerator OnMouseDown()
    {
        Debug.Log(this.gameObject.name + " was selected - on mouse down");
        Vector3 currentPosition = this.gameObject.transform.position;

        if (isZoomed)
        {
            viewCam.GetComponent<CameraController>().setView(cabinetCam.transform);
            isZoomed = false;
            targetPosition.z += Zmovement;
        }
        else
        {
            yield return new WaitForSeconds(0.5f);
            viewCam.GetComponent<CameraController>().setView(targetCam.transform);
            isZoomed = true;
            targetPosition.z -= Zmovement;

        }
        activeMovement = true;
    }


    void Update()
    {
    }

    private void LateUpdate()
    {
        if (activeMovement)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 1);
        }
        if (transform.position.Equals(targetPosition)) {
            activeMovement = false;
        }
    }

}
