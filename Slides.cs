using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slides : MonoBehaviour
{
    public GarmentsData data;
    public int current;
    //public GarmentPrefab[] garmentPrefabs;

    public GarmentPrefab itemPrefab;
    public GameObject arrowLeft;
    public GameObject arrowRight;
    //public Garment[] garmentBase;

    // Start is called before the first frame update
    void Start()
    {
        Setup();
        
    }

    // Update is called once per frame
    private void Setup()
    {
        if (data != null)
        {
            current = 0;
            SetPrefab(current);
            
            //save garments not prefabs
        }
    }

    private void SetPrefab(int i)
    {
        if (i < data.itemName.Length && i > -1)
        {
            itemPrefab.garment.outline = data.itemImage[i];
            itemPrefab.garment.primaryColor = data.primaryColor[i];
            itemPrefab.garment.secondaryColor = data.secondaryColor[i];
            itemPrefab.garment.tertiaryColor = data.tertiaryColor[i];
            itemPrefab.garment.title = data.itemName[i];
            itemPrefab.garment.offsetX = data.offsetX[i];
            itemPrefab.garment.offsetY = data.offsetY[i];
            itemPrefab.garment.scaleX = data.scaleX[i];
            itemPrefab.garment.scaleY = data.scaleY[i];
            itemPrefab.garment.arrayNumber = i;
            itemPrefab.garment.type = data.type;

            itemPrefab.thisImage.sprite = data.itemImage[i];
            itemPrefab.thisText.text = data.itemName[i];
        }
        itemPrefab.garment.Apply();
    }

    public void ChangeByButton(int value)
    {

        current = (current + value + data.itemName.Length) % (data.itemName.Length );
        SetPrefab(System.Math.Abs(current));
    }
}


 
