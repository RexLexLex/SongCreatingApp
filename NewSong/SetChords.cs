using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetChords : MonoBehaviour
{
    private int textscount;
    public GameObject Canvas;
    public GameObject TextClone;
    public Color RedColor = new Color32(255,0,0,255);
    public GameObject EndSettingButton;
    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("Canvas");
        EndSettingButton = Canvas.transform.GetChild(Canvas.transform.childCount-1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickSet()
    {
        textscount = Canvas.transform.childCount-10;
        for (int i = 0; i < textscount; i++)
        {
            //Debug.Log(i);
            TextClone = Canvas.transform.GetChild(i + 9).gameObject;//.GetComponent<TextMeshProUGUI>().color=RedColor;
            TextClone.GetComponent<TextMeshProUGUI>().color = RedColor;

            EndSettingButton.SetActive(true);
        }
        Debug.Log("Numero de acordes a posicionar: "+textscount);
    }
}
