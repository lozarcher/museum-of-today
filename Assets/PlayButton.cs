using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;

public class PlayButton : MonoBehaviour
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

    void OnMouseDown()
    {
        Debug.Log("PLAY pressed");

        VideoPlayer videoPlayer = videoPlayerObject.GetComponent<VideoPlayer>();
        if (!videoPlayer.isPlaying)
        {
            videoPlayer.Play();
        }
    }
}
