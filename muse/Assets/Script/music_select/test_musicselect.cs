using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test_musicselect : MonoBehaviour
{
    public Set_false set;
    public void Event()
    {
        setting.bpm = 120f;
        setting.music_time = 126f;
        set.set_false();
        setting.test = true;
        SceneManager.LoadScene("Game_Scene");
    }
}
