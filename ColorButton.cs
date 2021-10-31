using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    public Image image;
    public ColorPanel colorPanel;
    public Stage stage;
    private GameObject colorPart;

    // Start is called before the first frame update
    public void ChangeColor()
    {
        Color newColor = new Color
        {
            r = image.color.r,
            g = image.color.g,
            b = image.color.b,
            a = 1
        };
        //if headwear id != 0
        colorPart = colorPanel.colorPart;
        colorPart.GetComponent<SpriteRenderer>().color = newColor; 
    }
    // Update is called once per frame
    void Start()
    {
        stage = GameObject.FindWithTag("Stage").GetComponent<Stage>();
        colorPanel = GameObject.FindWithTag("ColorPanel").GetComponent<ColorPanel>();
    }
}
