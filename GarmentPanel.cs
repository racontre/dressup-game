using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GarmentPanel : MonoBehaviour
{
    public GarmentsData garmentsData;

    public GameObject itemPrefab;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        SetUp(garmentsData, panel);
    }

    // Update is called once per frame

    public void SetUp(GarmentsData data, GameObject panel)
    {
       
            if (data != null)
            {
                for (int i = 0; i < data.itemImage.Length; i++)
                {
                    GameObject headthing = Instantiate(itemPrefab,
                        panel.transform.position, Quaternion.identity);
                    headthing.transform.SetParent(panel.transform, false);

                    
                    GarmentPrefab prefab = headthing.GetComponent<GarmentPrefab>();
                    prefab.garment.outline = data.itemImage[i];
                    prefab.garment.primaryColor = data.primaryColor[i];
                    prefab.garment.secondaryColor = data.secondaryColor[i];
                    prefab.garment.tertiaryColor = data.tertiaryColor[i];
                    prefab.garment.title = data.itemName[i];
                    prefab.garment.offsetX = data.offsetX[i];
                    prefab.garment.offsetY = data.offsetY[i];
                    prefab.garment.scaleX = data.scaleX[i];
                    prefab.garment.scaleY = data.scaleY[i];
                    prefab.garment.arrayNumber = i;
                    prefab.garment.type = data.type;
                }
            }
        
    }
	
}
