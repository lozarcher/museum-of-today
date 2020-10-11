using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PauseButton : MonoBehaviour
{
    public GameObject videoPlayerObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        VideoPlayer videoPlayer=  videoPlayerObject.GetComponent<VideoPlayer>();
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
        }
    }
}
