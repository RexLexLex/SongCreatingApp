using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePopUp : MonoBehaviour
{
    public GameObject popupwarning;
    public GameObject popchords;
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("Canvas");
        //gameObject.transform.parent.gameObject.SetActive(false);
        //PopUpChords = GameObject.FindGameObjectsWithTag("PopUp")[1];
        popupwarning = Canvas.transform.GetChild(Canvas.transform.childCount-1).gameObject;//GameObject.FindGameObjectsWithTag("PopUp")[2];
        popchords= Canvas.transform.GetChild(7).gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickVanish()
    {
        //Debug.Log(gameObject.transform.parent.name);
        //gameObject.transform.parent.gameObject.SetActive(false);
        popupwarning.SetActive(false);
    }
    public void OnClickVanishChords()
    {
        popchords.SetActive(false);
    }
}
