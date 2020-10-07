using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float transitionSpeed;
    Transform currentView;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void setView(Transform newView)
    {
        currentView = newView;
        Debug.Log("New View " + currentView.position.x + " " + currentView.position.y + " " + currentView.position.z);
        Debug.Log("Transition speed " + transitionSpeed);

        Debug.Log("Set new view in camera controller");
    }

    void LateUpdate()
    {
        if (currentView != null)
        {

            Debug.Log("Target View " + currentView.position.x + " " + currentView.position.y + " " + currentView.position.z);

            Debug.Log("Transform "+transform.position.x + " " + transform.position.y + " " + transform.position.z);

        //Lerp position
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
