﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class PopupMessage : MonoBehaviour
{

    private const string imageUrlPrefix = "http://themuseumoftoday.org/wp-content/uploads/labels/large/";
    private const string imageUrlSuffix = "_large.png";


    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        ui.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
     * Synchronous loading from file system
    public void Open(string message, string wonderId)
    {
        ui.SetActive(!ui.activeSelf);

        Text textObject = ui.gameObject.GetComponentInChildren<Text>();
        textObject.text = message;

        GameObject labelObject = GameObject.Find("LabelImage");
        Image labelImage = labelObject.GetComponentInChildren<Image>();

        IMG2Sprite img2Sprite = new IMG2Sprite();
        labelImage.overrideSprite = img2Sprite.LoadNewSprite("Assets/Large Labels/" + wonderId + "_large.png");

    }
    */

    // Async loading from URL
    public void OpenAsync(string message, string wonderId)
    {
        ui.SetActive(!ui.activeSelf);

        Text textObject = ui.gameObject.GetComponentInChildren<Text>();
        textObject.text = message;

        string imageUrl = imageUrlPrefix + wonderId + imageUrlSuffix;
        Debug.Log(imageUrl);

        StartCoroutine(DownloadImage(imageUrl));
        

    }
    public void Close()
    {
        ui.SetActive(!ui.activeSelf);
        if (!ui.activeSelf)
        {
            Time.timeScale = 1f;
        }
    }

    IEnumerator DownloadImage(string MediaUrl)
    {
        GameObject labelObject = GameObject.Find("LabelImage");
        RawImage labelImage = labelObject.GetComponent<RawImage>();
        labelImage.texture = null;
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();

        if (request.isNetworkError || request.isHttpError)
            Debug.Log(request.error);
        else
            labelImage.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
    }

    public bool IsActive()
    {
        return ui.activeSelf;
    }
}
