using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class combo_txt : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI comboText;
    public Score score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        comboText.SetText("{0}",score.Combo);
    }
}
