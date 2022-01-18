using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Text_script : MonoBehaviour
{
    public TextMeshProUGUI input;
    public TMP_InputField user_inputfield;
    public GameObject PopUp;
    public GameObject popupchords;
    public GameObject popupwarning;

    public popup popup_script;
    public popupchords popupchords_script;

    private GameObject empty;
    public GameObject Canvas;
    public GameObject EndSettingButton;
    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("Canvas");
        PopUp = GameObject.Find("BackGroundPopUp");
        //popupchords = GameObject.FindGameObjectsWithTag("PopUp");
        //Debug.Log(GameObject.FindGameObjectsWithTag("PopUp")[0].name);
        popupchords= Canvas.transform.GetChild(7).gameObject;
        popupwarning = Canvas.transform.GetChild(8).gameObject;
        popupchords.SetActive(false);
        popupwarning.SetActive(false);

        EndSettingButton = Canvas.transform.GetChild(Canvas.transform.childCount - 1).gameObject;
        EndSettingButton.SetActive(false);
        //UnityEngine.UI.Text score;
        //score = GetComponent<UnityEngine.UI.Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput()
    {
        //empty = gameObject.transform;
        input.text = user_inputfield.text;
        PopUp.SetActive(false);
        //popupchords.SetActive(false);


        //gameObject.SetActive(false);

        //transform.parent.
        //gameObject.set
    }

    public void closePopUpwarning()
    {
        popupwarning.SetActive(false);
    }
}
