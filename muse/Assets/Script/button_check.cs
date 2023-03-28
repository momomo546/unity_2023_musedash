using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_check : MonoBehaviour
{
    public notes_rabbithouse Notes_rabithouse;
    private float time;
    // Update is called once per frame
    void Update()
    {
        time+=Time.deltaTime;
        if (Input.GetKeyDown (KeyCode.D)) {
            Debug.Log("a");
            check(time-Notes_rabithouse.list_time_r[0],Notes_rabithouse.list_time_r,Notes_rabithouse.list_object_r);
        }
        if (Input.GetKeyDown (KeyCode.F)) {
            Debug.Log("Perfect");
            check(time-Notes_rabithouse.list_time_b[0],Notes_rabithouse.list_time_b,Notes_rabithouse.list_object_b);
        }
        if (Input.GetKeyDown (KeyCode.J)) {
            check(time-Notes_rabithouse.list_time_g[0],Notes_rabithouse.list_time_g,Notes_rabithouse.list_object_g);
        }
        if (Input.GetKeyDown (KeyCode.K)) {
            check(time-Notes_rabithouse.list_time_y[0],Notes_rabithouse.list_time_y,Notes_rabithouse.list_object_y);
        }
    }
    void check(float notes_time,List<float> list_notestime,List<GameObject> list_notes)
    {
        if (Mathf.Abs(notes_time)<0.04f) {
            Debug.Log("Perfect");
            list_notestime.RemoveAt(0);
            Destroy(list_notes[0]);
        }
        else if (Mathf.Abs(notes_time)<0.1f) {
            Debug.Log("Great");
            list_notestime.RemoveAt(0);
            Destroy(list_notes[0]);
        }
        else if (Mathf.Abs(notes_time)<0.2f) {
            Debug.Log("Good");
            list_notestime.RemoveAt(0);
            Destroy(list_notes[0]);
        }
        else if (Mathf.Abs(notes_time)<0.3f) {
            Debug.Log("Bad");
            list_notestime.RemoveAt(0);
            Destroy(list_notes[0]);
        }
    }
}
