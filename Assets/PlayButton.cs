using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;

public class PlayButton : MonoBehaviour
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
        Debug.Log("PLAY pressed");

        VideoPlayer videoPlayer = videoPlayerObject.GetComponent<VideoPlayer>();
        if (!videoPlayer.isPlaying)
        {
            videoPlayer.Play();
        }
    }
}
