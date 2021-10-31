using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPanel : MonoBehaviour
{
    public GameObject colorPrefab;
    public GameObject panel;
    public Image colorImg;
    public Color newColor;
    public GameObject colorPart;
    public Stage stage;

    // Start is called before the first frame update
    void Start()
    {
        //Setup();
        stage = GameObject.FindWithTag("Stage").GetComponent<Stage>();
        colorPart = stage.activeGarment.primaryColor;//if primary color not found close the color menu
    }

    // Update is called once per frame
    private void Setup()
    {
        if (colorPrefab != null && panel != null)
        {
            for (int i = 1; i <= 15; i++)
            {
                InstantiateColorButton((float)i / 10, (float)i / 10, (float)i / 10);
            }
            
            
         }
    }

    private void InstantiateColorButton(float r, float g, float b)
    {
        GameObject colorButton = Instantiate(colorPrefab,
        panel.transform.position, Quaternion.identity);
        colorButton.transform.SetParent(panel.transform, false);
        colorImg = colorPrefab.GetComponent<ColorButton>().image;
        newColor.r = (float)r;
        newColor.g = (float)g;
        newColor.b = (float)b;
        newColor.a = 1.00f;
        colorImg.color = newColor;
    }

    public void SetColorPart(string part)
    {
        switch (part)
        {
            case "Primary":  colorPart = stage.activeGarment.primaryColor;
                break;
            case "Secondary": colorPart = stage.activeGarment.secondaryColor;
                break;
            case "Tertiary": colorPart = stage.activeGarment.tertiaryColor;
                break;
            default: colorPart = stage.activeGarment.primaryColor;
                break;
        }
    }
}
