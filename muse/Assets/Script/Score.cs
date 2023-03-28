using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    public int Perfect;
    public int Great;
    public int Good;
    public int Bad;
    public int Miss;
    public int Combo;
    // Update is called once per frame
    void Update()
    {
        score = Perfect*500+Great*300+Good*100+Bad*10;
    }
}
