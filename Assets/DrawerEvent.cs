﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DrawerEvent : MonoBehaviour
{
    public Camera targetCam;
    public Camera viewCam;
    public Camera cabinetCam;
    private bool activeMovement = false;

    private bool isZoomed = false;

    private Vector3 targetPosition;
    private float Zmovement = -0.4f;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
    }

    IEnumerator OnMouseDown()
    {
        Debug.Log("Active movement is " + activeMovement);
        if (!activeMovement)
        {
            Debug.Log(this.gameObject.name + " was selected - on mouse down");
            Vector3 currentPosition = this.gameObject.transform.position;

            if (isZoomed)
            {
                targetPosition.z += Zmovement;
                activeMovement = true;

                viewCam.GetComponent<CameraController>().setView(cabinetCam.transform);
                isZoomed = false;
            }
            else
            {
                Debug.Log("Starting drawer movement");

                targetPosition.z -= Zmovement;
                activeMovement = true;
                isZoomed = true;

                Debug.Log("Wait");

                yield return new WaitForSeconds(1.5f);

                Debug.Log("Now move camera");

                viewCam.GetComponent<CameraController>().setView(targetCam.transform);

            }
        }
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

        float dist = Vector3.Distance(targetPosition, transform.position);
        const float absoluteDifference = 0.01f;
        if (dist <= absoluteDifference)
        {
            activeMovement = false;
        }
        //if (transform.position.Equals(targetPosition)) {
        //    activeMovement = false;
        //}
    }

}
