using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndSettingButton : MonoBehaviour
{
    public GameObject Canvas;
    Color Black = new Color32(0, 0, 0, 255);
    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    public void OnClickColorandVanish()
    {
        for (int i = 0; i < Canvas.transform.childCount*2; i++)
        {
            if (Canvas.transform.GetChild(i).gameObject.name == "Text(Clone)" || Canvas.transform.GetChild(i).gameObject.name == "Text(Clone)(Clone)")
            {
                Canvas.transform.GetChild(i).GetComponent<TextMeshProUGUI>().color = Black;
            }
        }
        gameObject.SetActive(false);
    }
}
