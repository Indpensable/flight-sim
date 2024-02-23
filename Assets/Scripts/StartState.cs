using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartState : MonoBehaviour
{

    private string nonEssentialChecks;
    private string essentialChecks;
    [SerializeField] private TextMeshProUGUI textArea;
    // Start is called before the first frame update
    void Start()
    {
        string[] ne = { "1", "2", "3" };
        string[] e = { "4", "5" };
        foreach (string n in ne)
        {
            nonEssentialChecks += n + "\n";
        }
        foreach (string n in e)
        {
            essentialChecks += n + "\n";
        }
        textArea.text = nonEssentialChecks + essentialChecks;
        textArea.color = new Color32(0, 0, 255, 255);
        string col = "0f0";
        string s1 = string.Format("<#{1}>{0}</color>", e[0],col);
        textArea.text += s1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
