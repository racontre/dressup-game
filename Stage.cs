using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage : MonoBehaviour
{
    public float x, y;

    public GameObject characterBase;
    public Character selectedObject;
    public GarmentSlot activeGarment;
    public Canvas UIcanvas;
    public GameObject garmentPanel;
    public GameObject characterPanel;
    public GameObject editButton;
    public GarmentsData[] garmentsData;
    public GarmentPrefab[,] garmentsPrefabs;

    // Start is called before the first frame update
    private void Start()
    {
        UIcanvas = GameObject.FindWithTag("UICanvas").GetComponent<Canvas>();

    }
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && UIcanvas != null)
        {
            
            UIcanvas.enabled = true;
        }
        if (selectedObject != null && editButton != null)
        {
            Button edit = editButton.GetComponent<Button>();
            edit.interactable = true;
        }
    }

    // Update is called once per frame
    public void FlipSwitch(bool value)
    {
        SpriteRenderer headSprite = selectedObject.head.GetComponent<SpriteRenderer>();
        SpriteRenderer bodySprite = selectedObject.body.GetComponent<SpriteRenderer>();
        SpriteRenderer headwearSprite = selectedObject.headwear.GetComponent<SpriteRenderer>();
        SpriteRenderer faceSprite = selectedObject.face.GetComponent<SpriteRenderer>();
        SpriteRenderer faceAccSprite = selectedObject.faceAccessory.GetComponent<SpriteRenderer>();
        SpriteRenderer outerTopSprite = selectedObject.outerTop.GetComponent<SpriteRenderer>();
        
        FlipLocalX(bodySprite, value);
        FlipLocalX(headwearSprite, value);
        FlipLocalX(faceSprite, value);
        FlipLocalX(faceAccSprite, value);
        FlipLocalX(outerTopSprite, value);
    }


    public void SpawnCharacter()
    {
        Vector2 initPosition = new Vector2(x, y);
        GameObject character = Instantiate(characterBase, initPosition, Quaternion.identity);
        character.name = Random.Range(0, 100) + " (character)";
    }

    private void FlipLocalX(SpriteRenderer spriteObject, bool value)
    {
        spriteObject.flipX = value;
        var tmp = spriteObject.transform.localPosition;
        tmp.x = -tmp.x;
        spriteObject.transform.localPosition = tmp;
    }

    public void EnterEditMode()
    {
        garmentPanel.SetActive(true);
        characterPanel.SetActive(true);
    }

    public void SetupGarmentPrefabs()
    {
        for (int i = 0; i < garmentsData.Length; i++)
        {
            for (int j = 0; j < garmentsData[i].itemName.Length; j++)
            {
                garmentsPrefabs[i, j].name = garmentsData[i].itemName[j];
            }
        }
    }

    public void SetActiveGarment(GameObject renderObject)
    {
        activeGarment = renderObject.GetComponent<GarmentSlot>();
        
    }
    

}
