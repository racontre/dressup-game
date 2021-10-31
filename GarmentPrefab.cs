using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GarmentPrefab : MonoBehaviour
{
    public Image thisImage;
    public Text thisText;
    public Garment garment;

    public int arrayNumber;

    private Stage stage;

    // Start is called before the first frame update
    void Start()
    {
        Garment garment = new Garment();
        Setup();
        stage = GameObject.FindWithTag("Stage").GetComponent<Stage>();
    }

    // Update is called once per frame
    void Setup()
    {
        thisImage.sprite = garment.outline;
        thisText.text = garment.title;
    }

    public void ChangeAttire()
    {
        garment.Apply();
    }

}
