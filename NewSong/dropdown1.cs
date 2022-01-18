using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dropdown1 : MonoBehaviour
{
    public TextMeshProUGUI ChordButtonText0;
    public TextMeshProUGUI ChordButtonText1;
    public TextMeshProUGUI ChordButtonText2;
    public TextMeshProUGUI ChordButtonText3;
    public TextMeshProUGUI ChordButtonText4;
    public TextMeshProUGUI ChordButtonText5;
    public TextMeshProUGUI ChordButtonText6;
    private string chord;
    private string chordtype;
    private int Num;
    private string Text;
    private string allchordsmajor = "CDEFGAB";

    public GameObject ChordDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void DropdownOptions(int val)
    {
        //int index = val;
        //si val =0 crea un nuevo deck

        if (val == 0)
        {
            chordtype = null;
        }
        else if (val == 1)
        {
            chordtype = "#";
        }
        else if (val == 2)
        {
            chordtype = "b";
        }
        else if (val == 3)
        {
            chordtype = "m";
        }
        else if (val == 4)
        {
            chordtype = "#m";
        }
        else if (val == 5)
        {
            chordtype = "bm";
        }
        else if (val == 6)
        {
            chordtype = "7";
        }

        for (int i = 0; i < 7; i++)
        {
            string gameobjecttext = "ChordButton" + i;
            ChordDisplay = GameObject.Find(gameobjecttext);
            chord = char.ToString(allchordsmajor[i]);
            ChordDisplay.transform.GetComponentInChildren<TextMeshProUGUI>().text = chord + chordtype;

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void GetText(string alltext)
    {
        string y = "";
        string text = "";
        int num;
        for (int i = 0; i < alltext.Length; i++)
        {
            //Debug.Log("char" + effectandqty[i]);
            if (char.IsDigit(alltext[i]))
            {
                //Debug.Log("char" + HP_Player.GetComponent<Text>().text[i]);
                y += char.ToString(alltext[i]);
            }
            else
            {
                if (char.ToString(alltext[i]) != " ")
                {
                    text += alltext[i];
                }

            }

        }
        num = int.Parse(y);
        Num = num;
        Text = text;
    }
}
