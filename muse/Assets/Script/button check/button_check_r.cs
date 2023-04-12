using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_check_r : MonoBehaviour
{
    public notes_set set;
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
    private float time2;
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
    void Update()
    {
        time+=Time.deltaTime;
        time2+=Time.deltaTime;
        if (Input.GetKeyDown (KeyCode.F)) {
            if(set.list_time_long_y.Count>=2&&set.list_time_long_y.Count%2==0){
                if(set.list_time_long_r.Count>=2&&set.list_time_long_r.Count%2==0){
                    if(set.list_time_long_r[0]>set.list_time_long_y[0])
                    {
                        check_long_y(set.list_time_long_y[0]-time,set.list_time_long_y[1]-time,set.list_time_long_y,set.list_object_long_y);
                    }
                    else{
                        check_long_r(set.list_time_long_r[0]-time,set.list_time_long_r[1]-time,set.list_time_long_r,set.list_object_long_r);
                    }

                }
                else{
                    check_long_y(set.list_time_long_y[0]-time,set.list_time_long_y[1]-time,set.list_time_long_y,set.list_object_long_y);
                }   
            }
            else if(set.list_time_long_r.Count>=2&&set.list_time_long_r.Count%2==0)
            {
                check_long_r(set.list_time_long_r[0]-time,set.list_time_long_r[1]-time,set.list_time_long_r,set.list_object_long_r);
            }
        }
        if (Input.GetKeyDown (KeyCode.J)) {
            if(set.list_time_long_y.Count>=2&&set.list_time_long_y.Count%2==0){
                if(set.list_time_long_r.Count>=2&&set.list_time_long_r.Count%2==0){
                    if(set.list_time_long_r[0]>set.list_time_long_y[0])
                    {
                        check_long_y(set.list_time_long_y[0]-time,set.list_time_long_y[1]-time,set.list_time_long_y,set.list_object_long_y);
                    }
                    else{
                        check_long_r(set.list_time_long_r[0]-time,set.list_time_long_r[1]-time,set.list_time_long_r,set.list_object_long_r);
                    }

                }
                else{
                    check_long_y(set.list_time_long_y[0]-time,set.list_time_long_y[1]-time,set.list_time_long_y,set.list_object_long_y);
                }   
            }
            else if(set.list_time_long_r.Count>=2&&set.list_time_long_r.Count%2==0)
            {
                check_long_r(set.list_time_long_r[0]-time,set.list_time_long_r[1]-time,set.list_time_long_r,set.list_object_long_r);
            }
        }
        if(set.list_time_long_r.Count!=0)
        {
            if(set.list_time_long_r[0]-time<-0.3f)
            {
                miss_up(set.list_time_long_r,set.list_object_long_r);
            }
        }
        if(set.list_time_long_b.Count!=0)
        {
            if(set.list_time_long_b[0]-time<-0.3f)
            {
                miss_down(set.list_time_long_b,set.list_object_long_b);
            }
        }
        if(set.list_time_long_g.Count!=0)
        {
            if(set.list_time_long_g[0]-time<-0.3f)
            {
                miss_down(set.list_time_long_g,set.list_object_long_g);
            }
        }
        if(set.list_time_long_y.Count!=0)
        {
            if(set.list_time_long_y[0]-time<-0.3f)
            {
                miss_up(set.list_time_long_y,set.list_object_long_y);
            }
        }
    }
    void check_txt_up(float notes_time,List<float> list_notestime,List<GameObject> list_notes){
        if (Mathf.Abs(notes_time)<0.04f) {
            remove(list_notestime,list_notes);
            Instantiate(Perfect_up, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            Score.Perfect++;
            Score.Combo++;
        }
        else if (Mathf.Abs(notes_time)<0.1f) {
            remove(list_notestime,list_notes);
            Instantiate(Great_up, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            Score.Great++;
            Score.Combo++;
        }
        else if (Mathf.Abs(notes_time)<0.2f) {
            remove(list_notestime,list_notes);
            Instantiate(Good_up, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            Score.Good++;
            Score.Combo=0;
        }
        else if (Mathf.Abs(notes_time)<0.3f) {
            remove(list_notestime,list_notes);
            Instantiate(Bad_up, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            Score.Bad++;
            Score.Combo=0;
        }
    }
    void check_long_r(float notes_time,float notes_time2,List<float> list_notestime,List<GameObject> list_notes)
    {
        time2=0;
        setting.button_long_up = true;
        check_txt_up(notes_time,list_notestime,list_notes);

        StartCoroutine(WaitUntil_r(notes_time2,list_notestime,list_notes));
    }
    void check_long_y(float notes_time,float notes_time2,List<float> list_notestime,List<GameObject> list_notes)
    {
        time2=0;
        setting.button_long_up = true;
        check_txt_up(notes_time,list_notestime,list_notes);

        StartCoroutine(WaitUntil_y(notes_time2,list_notestime,list_notes));
    }
    void miss_up(List<float> list_notestime,List<GameObject> list_notes)
    {
        remove(list_notestime,list_notes);
        Instantiate(Miss_up, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
        Score.Miss++;
        Score.Combo=0;
    }
    void miss_down(List<float> list_notestime,List<GameObject> list_notes)
    {
        remove(list_notestime,list_notes);
        Instantiate(Miss_down, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
        Score.Miss++;
        Score.Combo=0;
    }
    IEnumerator WaitUntil_r(float notes_time2,List<float> list_notestime,List<GameObject> list_notes){
        if(Input.GetKey(KeyCode.F)){
            yield return new WaitUntil(() => Input.GetKeyUp (KeyCode.F));
        }
        else if(Input.GetKey(KeyCode.J)){
            yield return new WaitUntil(() => Input.GetKeyUp (KeyCode.J));
        }
        setting.button_long_up = false;
        check_up2(notes_time2,list_notestime,list_notes);
    }
    IEnumerator WaitUntil_y(float notes_time2,List<float> list_notestime,List<GameObject> list_notes){
        if(Input.GetKey(KeyCode.F)){
            yield return new WaitUntil(() => Input.GetKeyUp (KeyCode.F));
        }
        else if(Input.GetKey(KeyCode.J)){
            yield return new WaitUntil(() => Input.GetKeyUp (KeyCode.J));
        }
        setting.button_long_up = false;
        check_up2(notes_time2,list_notestime,list_notes);
    }
    void check_up2(float notes_time2,List<float> list_notestime,List<GameObject> list_notes){
        notes_time2-=time2;
        if (Mathf.Abs(notes_time2)<0.08f) {
            remove(list_notestime,list_notes);
            Instantiate(Perfect_up, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            Score.Perfect++;
            Score.Combo++;
        }
        else if (Mathf.Abs(notes_time2)<0.14f) {
            remove(list_notestime,list_notes);
            Instantiate(Great_up, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            Score.Great++;
            Score.Combo++;
        }
        else if (Mathf.Abs(notes_time2)<0.24f) {
            remove(list_notestime,list_notes);
            Instantiate(Good_up, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            Score.Good++;
            Score.Combo=0;
        }
        else if (Mathf.Abs(notes_time2)<0.3f) {
            remove(list_notestime,list_notes);
            Instantiate(Bad_up, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            Score.Bad++;
            Score.Combo=0;
        }
    }
    void remove(List<float> list_notestime,List<GameObject> list_notes)
    {
        list_notestime.RemoveAt(0);
        Destroy(list_notes[0]);
        list_notes.RemoveAt(0);
    }
}
