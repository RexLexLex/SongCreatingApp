using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popupchords : MonoBehaviour
{
    public GameObject PopUpChords;
    public Text_script script;
    // Start is called before the first frame update
    void Start()
    {
        //PopUpChords = script.popupchords;
        //PopUpChords = GameObject.findfa
        //PopUpChords.SetActive(false);
        PopUpChords = GameObject.FindGameObjectsWithTag("PopUp")[1];
        //Debug.Log(GameObject.FindGameObjectsWithTag("PopUp")[1].name);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        //Debug.Log(PopUpChords.name);
        PopUpChords.SetActive(true);
    }
}
