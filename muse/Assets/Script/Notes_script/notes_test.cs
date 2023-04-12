using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notes_test : MonoBehaviour
{
    private float count = 0f;
    public notes_set set;
    public void test()
    {
        set.notes_long_r(count,0,0,0,count+1,0,0,0);
        count++;
        count++;
        set.notes_long_y(count,0,0,0,count+1,0,0,0);
        count++;
        count++;
        set.notes_long_g(count,0,0,0,count+1,0,0,0);
        count++;
        count++;
        set.notes_long_b(count,0,0,0,count+1,0,0,0);
        count++;
        count++;
    }
    
}
