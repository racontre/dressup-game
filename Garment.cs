using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Garment
{
	public GameObject parentObject;
    public float offsetX;
    public float offsetY;
    public float scaleX;
    public float scaleY;
    public string type;
    public int arrayNumber;

    public Sprite outline;
    public Sprite primaryColor;
    public Sprite secondaryColor;
    public Sprite tertiaryColor;
    public string title;

    private Stage stage;


    public void Apply()
    {
		// The function that updates the garment container info 
		// selectedObject = current character
        // type - refers to the type in the scriptable objects  dress up data
        stage = GameObject.FindWithTag("Stage").GetComponent<Stage>();
        if (stage.selectedObject != null)
        {
            GameObject spriteObject = stage.selectedObject.headwear;

            switch (type)
            {
                case "FaceAccessory":
                    spriteObject = stage.selectedObject.faceAccessory;
                    break;
                case "OuterTop":
                    spriteObject = stage.selectedObject.outerTop;
                    break;
				case "RightSleeve":
                    spriteObject = stage.selectedObject.rightSleeve;
                    break;
                case "Skin":
                    spriteObject = stage.selectedObject.head;
                    break;
				case "EyeLeft":
					spriteObject = stage.selectedObject.eyeLeft;
                    break;
				case "EyeRight":
					spriteObject = stage.selectedObject.eyeRight;
                    break;
				case "MouthShape":
					spriteObject = stage.selectedObject.mouth;
                    break;
				case "PantsLeft":
					spriteObject = stage.selectedObject.pantsLeft;
                    break;
                case "Pose":
                    stage.selectedObject.chareAnimator.SetInteger("poseNumber", arrayNumber);
                    break;
            }

            if (type != "Pose")
            {

                SpriteRenderer spritePrimary = spriteObject.GetComponent<GarmentSlot>().primaryColor.GetComponent<SpriteRenderer>();
                SpriteRenderer spriteSecondary = spriteObject.GetComponent<GarmentSlot>().secondaryColor.GetComponent<SpriteRenderer>();
                SpriteRenderer spriteTertiary = spriteObject.GetComponent<GarmentSlot>().tertiaryColor.GetComponent<SpriteRenderer>();
                spriteTertiary.sprite = tertiaryColor;
                SpriteRenderer spriteOutline = spriteObject.GetComponent<GarmentSlot>().outline.GetComponent<SpriteRenderer>();
                spriteOutline.sprite = outline;
                spritePrimary.sprite = primaryColor;
                spriteSecondary.sprite = secondaryColor;
				if (type != "MouthShape") 
				{
					spriteObject.transform.position = new Vector3
					(stage.selectedObject.transform.position.x + offsetX,
						stage.selectedObject.transform.position.y + offsetY, 
						stage.selectedObject.transform.position.z);
					spriteObject.transform.localScale = new Vector2(scaleX, scaleY);
				}
			
				if (type == "EyeRight")
				{
				
				}
				
            }
            
            
            spriteObject.GetComponent<GarmentSlot>().garmentHolder = this;
                        


        }
    }
}