using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupMessage : MonoBehaviour
{

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
    public void Close()
    {
        ui.SetActive(!ui.activeSelf);
        if (!ui.activeSelf)
        {
            Time.timeScale = 1f;
        }
    }
}
