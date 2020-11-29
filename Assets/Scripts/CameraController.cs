using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float transitionSpeed;
    Transform currentView;

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
   

}
