using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChordCreate : MonoBehaviour
{
    public TextMeshProUGUI m_text;
    public GameObject empty;
    public GameObject Canvas;
    public GameObject Textexample;
    public GameObject PopUpWarning;
    public GameObject PopUpChords;
    public int clicks=0;
    public TMP_Dropdown dropdown;
    private int change=0;
    private string textofchord;
    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("Canvas");
        Textexample = GameObject.Find("Text");
        PopUpWarning = Canvas.transform.GetChild(8).gameObject;
        PopUpChords= Canvas.transform.GetChild(7).gameObject;
        //dropdown=GameObject.FindGameObjectWithTag("DropDown").GetComponent<Dropdown>();
        //dropdown = GameObject.Find("Dropdown");
        //PopUpWarning.SetActive(false);
        //m_text = gameObject.AddComponent<TextMesh>();
        //m_text.SetParent(GameObject.Find("Canvas"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        //PopUpWarning = GameObject.FindGameObjectsWithTag("PopUp")[2];
        //transform.SetParent(Canvas.transform, true); //transform stay where it is
        //m_text.transform.SetParent(Canvas.transform,true);
        //dropdown = GetComponent<Dropdown>();
        change = 0;
        dropdown.onValueChanged.AddListener(delegate { valuechanged(); });
        if (change==0)
        {
            for (int i = 8; i < Canvas.transform.childCount; i++)
            {
                if (Canvas.transform.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().text == transform.GetComponentInChildren<TextMeshProUGUI>().text)
                {
                    clicks = 2;
                }
            }
            if (clicks == 0)
            {
                empty = Instantiate(Textexample);//Canvas.AddComponent<TextMeshProUGUI>();
                empty.transform.SetParent(Canvas.transform, true);
                empty.GetComponent<TextMeshProUGUI>().text = transform.GetComponentInChildren<TextMeshProUGUI>().text;
                empty.transform.localPosition = new Vector2(440, 1080-320-((Canvas.transform.childCount-9)*100));
                empty.GetComponent<RectTransform>().sizeDelta = new Vector2(250, 100);
                //empty.GetComponent<TextMeshPro>().alignment = TextAlignmentOptions.Center;
                clicks++;
                PopUpChords.transform.SetSiblingIndex(Canvas.transform.childCount - 1);
            }
            else
            {
                //Debug.Log("No more clicks required/ " + "Dropdown name: " + dropdown.options[0].text + " and number of clicks: " + clicks + " " + change);
                PopUpWarning.SetActive(true);
                PopUpWarning.transform.SetSiblingIndex(Canvas.transform.childCount-1);
                change = 0;
            }
            
            
        }
        else
        {
            
            //Debug.Log("No more clicks required/ " + "Dropdown name: " + dropdown.options[0].text + " and number of clicks: " + clicks+ " "+change);
            PopUpWarning.SetActive(true);
            PopUpWarning.transform.SetSiblingIndex(Canvas.transform.childCount-1);
            change = 0;
        }
        
        //Canvas.AddComponent<>();
        //GameObject.Instantiate(TextMeshProUGUI);
    }

    void valuechanged()
    {
        change++;
        clicks = 0;
        //Debug.Log(change);
    }
}
