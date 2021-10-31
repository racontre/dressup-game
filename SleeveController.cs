using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleeveController : MonoBehaviour
{
    public Animator sleeveAnimator;
    public Stage stage;

    // Start is called before the first frame update
    void Start()
    {
        stage = GameObject.FindWithTag("Stage").GetComponent<Stage>();
    }

    // Update is called once per frame
    public void ChangePoseByIntValue(int value)
    {
        if (stage.selectedObject != null)
        {
            stage.selectedObject.chareAnimator.SetInteger("enumPose", value);
        }
    }
}
