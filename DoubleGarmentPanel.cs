using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoubleGarmentPanel : MonoBehaviour
{
    public GarmentsData garmentsDataLeft;
	public GarmentsData garmentsDataRight;
    public GameObject itemPrefab;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        SetUp(garmentsDataRight, garmentsDataLeft, panel);
    }

    // Update is called once per frame

    public void SetUp(GarmentsData dataRight, GarmentsData dataLeft, GameObject panel)
    {
       
            if (dataRight != null && dataLeft != null)
            {
                for (int i = 0; i < dataRight.itemImage.Length; i++)
                {
					
                    GameObject headthing = Instantiate(itemPrefab,
                        panel.transform.position, Quaternion.identity);
                    headthing.transform.SetParent(panel.transform, false);

                    
                    DoubleGarmentPrefab prefab = headthing.GetComponent<DoubleGarmentPrefab>();
                    prefab.garmentRight.outline = dataRight.itemImage[i];
                    prefab.garmentRight.primaryColor = dataRight.primaryColor[i];
                    prefab.garmentRight.secondaryColor = dataRight.secondaryColor[i];
                    prefab.garmentRight.tertiaryColor = dataRight.tertiaryColor[i];
                    prefab.garmentRight.title = dataRight.itemName[i];
                    prefab.garmentRight.offsetX = dataRight.offsetX[i];
                    prefab.garmentRight.offsetY = dataRight.offsetY[i];
                    prefab.garmentRight.scaleX = dataRight.scaleX[i];
                    prefab.garmentRight.scaleY = dataRight.scaleY[i];
                    prefab.garmentRight.arrayNumber = i;
                    prefab.garmentRight.type = dataRight.type;
					
					prefab.garmentLeft.outline = dataLeft.itemImage[i];
                    prefab.garmentLeft.primaryColor = dataLeft.primaryColor[i];
                    prefab.garmentLeft.secondaryColor = dataLeft.secondaryColor[i];
                    prefab.garmentLeft.tertiaryColor = dataLeft.tertiaryColor[i];
                    prefab.garmentLeft.title = dataLeft.itemName[i];
                    prefab.garmentLeft.offsetX = dataLeft.offsetX[i];
                    prefab.garmentLeft.offsetY = dataLeft.offsetY[i];
                    prefab.garmentLeft.scaleX = dataLeft.scaleX[i];
                    prefab.garmentLeft.scaleY = dataLeft.scaleY[i];
                    prefab.garmentLeft.arrayNumber = i;
                    prefab.garmentLeft.type = dataLeft.type;
                }
            }
        
    }
	
}
