using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleGarment : MonoBehaviour
{
	public GameObject rightParent;
	public GameObject leftParent;
	
    public Garment rightGarment;
	public Garment leftGarment;


    public void DoubleApply()
    {
		leftGarment.Apply();
        rightGarment.Apply();
    }
}
