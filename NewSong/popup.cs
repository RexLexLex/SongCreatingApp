using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup : MonoBehaviour
{
    public GameObject PopUp;
    public Text_script script;
    // Start is called before the first frame update
    void Start()
    {
        //PopUp = GameObject.Find("BackGroundPopUp");
        PopUp = GameObject.FindGameObjectsWithTag("PopUp")[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        PopUp.SetActive(true);
    }
}
