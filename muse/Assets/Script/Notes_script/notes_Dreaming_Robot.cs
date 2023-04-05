using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notes_Dreaming_Robot : MonoBehaviour
{
    private int count = 0;
    public notes_set set;

    public void Dreaming_Robot()
    {
        //set.notes_r(count,0,0,0);
        //set.notes_three_b(count,3,0,0);
        //count++;
        
        count++;
        count++;
        set.notes_r(count,0,0,0);

    }
}