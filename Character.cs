using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



public class Character : MonoBehaviour
{
	//In order to be able to change the character's appearance,
	//You need to create a GameObject that will act as a container.
	//Add it to the switch cases in Garment.cs as well
    private Stage stage;
    private GameData gamedata;

    public string nameAssigned;

    public GameObject head;
	
	public GameObject eyeRight;
	public GameObject eyeLeft;
	public GameObject mouth;

    public GameObject body;

    public GameObject face;

    public GameObject headwear;

    public GameObject faceAccessory;

    public GameObject outerTop;
	
	public GameObject rightSleeve;
	public GameObject leftSleeve;
	
	public GameObject pantsLeft;
	
    public Sprite skin; //flag

    public float zPosition = 10;

    public Animator chareAnimator;

    

    // Start is called before the first frame update
    void Start()
    {
        stage = GameObject.FindWithTag("Stage").GetComponent<Stage>();
        
    }
    

  /*  private void OnMouseDrag()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = zPosition;
        transform.position = Camera.main.ScreenToWorldPoint(mousePos);
        if (Input.touchCount > 0)
        {

        }
        Debug.Log(transform.position);


    }*/

   /* private void OnMouseDown()
    {
        stage.selectedObject = this;
    }*/

    public void Save()
    {

    }

    // Features:
    // Draggable(done), resizable(not quite but close), modifiable(kinda but still a long way to go)

}
