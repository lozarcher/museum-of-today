using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float transitionSpeed;
    Transform currentView;

    //Unused, for mouselook
    /* 
    bool currentlyMoving = false;
    const float positionsPrettyClose = 0.1f;
    private Vector3 lastMouse = new Vector3(Screen.height / 2, Screen.width / 2, 0); //kind of in the middle of the screen, rather than at the top (play)
    float camSens = 1f; //How sensitive it with mouse
    */

    // Start is called before the first frame update
    void Start()
    {
    }

    public void setView(Transform newView, float transitionSpeed)
    {
        currentView = newView;
        this.transitionSpeed = transitionSpeed;
        //currentlyMoving = true;
    }

    void LateUpdate()
    {
        if (currentView != null)
        {
                transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);
                Vector3 currentAngle = new Vector3(
                    Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
                    Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
                    Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed)
                );
                transform.eulerAngles = currentAngle;
        }
    }
    /* unused, for mouselook
    void LateUpdate() {
        if (currentView != null) {
            if (currentlyMoving) {
                if (Vector3.Distance(transform.position, currentView.position) < positionsPrettyClose)
                {
                    currentlyMoving = false;
                }
            }

            if (currentlyMoving)
            {
                //Lerp position to new target
                transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);
                Vector3 currentAngle = new Vector3(
                    Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
                    Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
                    Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed)
                );
                transform.eulerAngles = currentAngle;
            }
            else
            {
                // Allow Mouse Movement
                Debug.Log("mouse position " + Input.mousePosition);
                lastMouse = Input.mousePosition - lastMouse;
                lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0);
                lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);
                transform.eulerAngles = lastMouse;
                lastMouse = Input.mousePosition;
            }
        }
    }
    */

}
