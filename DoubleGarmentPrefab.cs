using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoubleGarmentPrefab : MonoBehaviour
{
    public Image thisImage;
    public Text thisText;
    public Garment garmentRight;
	public Garment garmentLeft;
    public int arrayNumber;

    private Stage stage;

    // Start is called before the first frame update
    void Start()
    {
        Garment garmentRight = new Garment();
		Garment garmentLeft = new Garment();
        Setup();
        stage = GameObject.FindWithTag("Stage").GetComponent<Stage>();
    }

    // Update is called once per frame
    void Setup()
    {
        thisImage.sprite = garmentRight.outline;
		
        thisText.text = garmentRight.title;
    }

    public void ChangeAttire()
    {
        garmentRight.Apply();
		garmentLeft.Apply();
		Debug.Log("reachable");
    }

}
