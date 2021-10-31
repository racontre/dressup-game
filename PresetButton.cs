using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresetButton : MonoBehaviour
{
    private Stage stage;
    public Preset preset;
    private GameData gameData;
    public int presetNumber;
    // Start is called before the first frame update
    void Start()
    {
        stage = GameObject.FindWithTag("Stage").GetComponent<Stage>();
        gameData = GameObject.FindWithTag("GameData").GetComponent<GameData>();
        LoadPreset();
    }

    // Update is called once per frame
    public void setPreset()
    {
        
        if (stage.selectedObject != null)
        {
            //preset.headwear = stage.selectedObject.headwear.GetComponent<SpriteRenderer>().sprite;
            preset.headwear = stage.selectedObject.headwear.GetComponent<GarmentSlot>().garmentHolder;
            preset.accessory = stage.selectedObject.faceAccessory.GetComponent<GarmentSlot>().garmentHolder;
            preset.pose = stage.selectedObject.body.GetComponent<GarmentSlot>().garmentHolder;
            preset.outerTop = stage.selectedObject.outerTop.GetComponent<GarmentSlot>().garmentHolder;
            //Preset.Save
            gameData.saveData.presets[presetNumber] = preset;
            
            gameData.Save();
            Debug.Log("Preset set" + gameData.saveData.presets[0]);
        }
    }

    public void applyPreset()
    {
        if (stage.selectedObject != null)
        {
            // stage.selectedObject.headwear.GetComponent<SpriteRenderer>().sprite = preset.headwear;
            preset.headwear.Apply();
            preset.accessory.Apply();
            preset.pose.Apply();
            preset.outerTop.Apply();
        }
    }

    public void LoadPreset()
    {
        {
            if (gameData.saveData.presets[presetNumber] != null)
            {
                preset = gameData.saveData.presets[presetNumber];
            }
        }
    }
}
