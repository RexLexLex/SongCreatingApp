using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DragChords : MonoBehaviour
{
    Color RedColor = new Color32(255, 0, 0, 255);
    public bool IsDragging = false;
    public GameObject Canvas;
    public GameObject newChord;
    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    public void BDrag()
    {
        if (gameObject.GetComponent<TextMeshProUGUI>().color == RedColor)
        {
            IsDragging = true;
            newChord = Instantiate(gameObject);

        }
    }

    public void EDrag()
    {
        IsDragging = false;
    }
    void Update()
    {
        if (newChord != null)
        {
            if (IsDragging)
            {
                newChord.transform.SetParent(Canvas.transform, true);
                newChord.transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            }
        }
        
    }
}
