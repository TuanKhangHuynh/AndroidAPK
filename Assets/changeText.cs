using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class changeText : MonoBehaviour
{
    public RectTransform noteConsoleLog;
    public TextMeshProUGUI noteConsolePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addMoreText(string _text)
    {
        noteConsolePanel.text += _text;
    }

    public void resetText()
    {
        noteConsolePanel.text = "";
    }
}
