using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI checkList;
    [SerializeField] private TextMeshProUGUI valueList;
    [SerializeField] private Image imgHold;
    [SerializeField] private Sprite oldS;
    [SerializeField] private Sprite newS;
    [SerializeField] private Button switchB;

    public void changeText(string key,string value,string col)
    {
        if (col == "g")
        {
            checkList.text = "<#0f0>"+key+"</color>";
            valueList.text = "<#0f0>"+value+"</color>";
        }
    }

    private void Start()
    {
        switchB.onClick.AddListener(ChangeImg);
    }

    void ChangeImg()
    {
        imgHold.sprite = newS;
        newS = oldS;
        oldS = imgHold.sprite;
    }
}   
