using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;

public class PauseButton : MonoBehaviour
{
    private GameObject videoPlayerObject;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayerObject = GameObject.Find("Video Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked()
    {
        Debug.Log("PAUSE pressed");
        VideoPlayer videoPlayer=  videoPlayerObject.GetComponent<VideoPlayer>();
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
        }
    }
}
