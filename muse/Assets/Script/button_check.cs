using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_check : MonoBehaviour
{
    public notes_rabbithouse Notes_rabithouse;
    public Score score;
    private GameObject clone;
    private GameObject Perfect_up;
    private GameObject Great_up;
    private GameObject Good_up;
    private GameObject Bad_up;
    private GameObject Miss_up;
    private GameObject Perfect_down;
    private GameObject Great_down;
    private GameObject Good_down;
    private GameObject Bad_down;
    private GameObject Miss_down;
    private float time;

    void Start()
    {
        Perfect_up = (GameObject)Resources.Load ("Perfect_up");
        Great_up = (GameObject)Resources.Load ("Great_up");
        Good_up = (GameObject)Resources.Load ("Good_up");
        Bad_up = (GameObject)Resources.Load ("Bad_up");
        Miss_up = (GameObject)Resources.Load ("Miss_up");
        Perfect_down = (GameObject)Resources.Load ("Perfect_down");
        Great_down = (GameObject)Resources.Load ("Great_down");
        Good_down = (GameObject)Resources.Load ("Good_down");
        Bad_down = (GameObject)Resources.Load ("Bad_down");
        Miss_down = (GameObject)Resources.Load ("Miss_down");
    }
    // Update is called once per frame
    void Update()
    {
        time+=Time.deltaTime;
        if (Input.GetKeyDown (KeyCode.D)) {
            Debug.Log("d");
            if(Notes_rabithouse.list_time_r.Count!=0)
            {
            check_up(Notes_rabithouse.list_time_r[0]-time,Notes_rabithouse.list_time_r,Notes_rabithouse.list_object_r);
            }
        }
        if (Input.GetKeyDown (KeyCode.F)) {
            Debug.Log("f");
            if(Notes_rabithouse.list_time_b.Count!=0)
            {
            check_up(Notes_rabithouse.list_time_b[0]-time,Notes_rabithouse.list_time_b,Notes_rabithouse.list_object_b);
            }
        }
        if (Input.GetKeyDown (KeyCode.J)) {
            Debug.Log("j");
            if(Notes_rabithouse.list_time_g.Count!=0)
            {
            check_down(Notes_rabithouse.list_time_g[0]-time,Notes_rabithouse.list_time_g,Notes_rabithouse.list_object_g);
            }
        }
        if (Input.GetKeyDown (KeyCode.K)) {
            Debug.Log("k");
            if(Notes_rabithouse.list_time_y.Count!=0)
            {
            check_down(Notes_rabithouse.list_time_y[0]-time,Notes_rabithouse.list_time_y,Notes_rabithouse.list_object_y);
            }
        }
        if(Notes_rabithouse.list_time_r.Count!=0)
        {
            if(Notes_rabithouse.list_time_r[0]-time<-0.3f)
            {
                miss_up(Notes_rabithouse.list_time_r,Notes_rabithouse.list_object_r);
            }
        }
        if(Notes_rabithouse.list_time_b.Count!=0)
        {
            if(Notes_rabithouse.list_time_b[0]-time<-0.3f)
            {
                miss_up(Notes_rabithouse.list_time_b,Notes_rabithouse.list_object_b);
            }
        }
        if(Notes_rabithouse.list_time_g.Count!=0)
        {
            if(Notes_rabithouse.list_time_g[0]-time<-0.3f)
            {
                miss_down(Notes_rabithouse.list_time_g,Notes_rabithouse.list_object_g);
            }
        }
        if(Notes_rabithouse.list_time_y.Count!=0)
        {
            if(Notes_rabithouse.list_time_y[0]-time<-0.3f)
            {
                miss_down(Notes_rabithouse.list_time_y,Notes_rabithouse.list_object_y);
            }
        }
        
    }
    void check_up(float notes_time,List<float> list_notestime,List<GameObject> list_notes)
    {
        if (Mathf.Abs(notes_time)<0.04f) {
            Debug.Log("Perfect");
            remove(list_notestime,list_notes);
            Instantiate(Perfect_up, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            score.Perfect++;
            score.Combo++;
        }
        else if (Mathf.Abs(notes_time)<0.1f) {
            Debug.Log("Great");
            remove(list_notestime,list_notes);
            Instantiate(Great_up, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            score.Great++;
            score.Combo++;
        }
        else if (Mathf.Abs(notes_time)<0.2f) {
            Debug.Log("Good");
            remove(list_notestime,list_notes);
            Instantiate(Good_up, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            score.Good++;
            score.Combo=0;
        }
        else if (Mathf.Abs(notes_time)<0.3f) {
            Debug.Log("Bad");
            remove(list_notestime,list_notes);
            Instantiate(Bad_up, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            score.Bad++;
            score.Combo=0;
        }
    }
    void check_down(float notes_time,List<float> list_notestime,List<GameObject> list_notes)
    {
        if (Mathf.Abs(notes_time)<0.04f) {
            Debug.Log("Perfect");
            remove(list_notestime,list_notes);
            Instantiate(Perfect_down, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            score.Perfect++;
            score.Combo++;
        }
        else if (Mathf.Abs(notes_time)<0.1f) {
            Debug.Log("Great");
            remove(list_notestime,list_notes);
            Instantiate(Great_down, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            score.Great++;
            score.Combo++;
        }
        else if (Mathf.Abs(notes_time)<0.2f) {
            Debug.Log("Good");
            remove(list_notestime,list_notes);
            Instantiate(Good_down, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            score.Good++;
            score.Combo=0;
        }
        else if (Mathf.Abs(notes_time)<0.3f) {
            Debug.Log("Bad");
            remove(list_notestime,list_notes);
            Instantiate(Bad_down, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            score.Bad++;
            score.Combo=0;
        }
    }
    void remove(List<float> list_notestime,List<GameObject> list_notes)
    {
        list_notestime.RemoveAt(0);
        Destroy(list_notes[0]);
        list_notes.RemoveAt(0);
    }
    void miss_up(List<float> list_notestime,List<GameObject> list_notes)
    {
        Debug.Log("Miss");
        remove(list_notestime,list_notes);
        Instantiate(Miss_up, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
        score.Miss++;
        score.Combo=0;
    }
    void miss_down(List<float> list_notestime,List<GameObject> list_notes)
    {
        Debug.Log("Miss");
        remove(list_notestime,list_notes);
        Instantiate(Miss_down, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
        score.Miss++;
        score.Combo=0;
    }
}
