using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_check_b : MonoBehaviour
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
        if(setting.button_distinction!=false){
            this.GetComponent<button_check_no_distinction>().enabled = false;
        }
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
        time2+=Time.deltaTime;
        if (Input.GetKeyDown (KeyCode.V)) {
            if(set.list_time_long_b.Count>=2&&set.list_time_long_b.Count%2==0){
                if(set.list_time_long_g.Count>=2&&set.list_time_long_g.Count%2==0){
                    if(set.list_time_long_g[0]>set.list_time_long_b[0])
                    {
                        check_long_b(set.list_time_long_b[0]-time,set.list_time_long_b[1]-time,set.list_time_long_b,set.list_object_long_b);
                    }
                    else{
                        check_long_g(set.list_time_long_g[0]-time,set.list_time_long_g[1]-time,set.list_time_long_g,set.list_object_long_g);
                    }

                }
                else{
                    check_long_b(set.list_time_long_b[0]-time,set.list_time_long_b[1]-time,set.list_time_long_b,set.list_object_long_b);
                }   
            }
            else if(set.list_time_long_g.Count>=2&&set.list_time_long_g.Count%2==0)
            {
                check_long_g(set.list_time_long_g[0]-time,set.list_time_long_g[1]-time,set.list_time_long_g,set.list_object_long_g);
            }
        }

        if (Input.GetKeyDown (KeyCode.N)) {
            if(set.list_time_long_b.Count>=2&&set.list_time_long_b.Count%2==0){
                if(set.list_time_long_g.Count>=2&&set.list_time_long_g.Count%2==0){
                    if(set.list_time_long_g[0]>set.list_time_long_b[0])
                    {
                        check_long_b(set.list_time_long_b[0]-time,set.list_time_long_b[1]-time,set.list_time_long_b,set.list_object_long_b);
                    }
                    else{
                        check_long_g(set.list_time_long_g[0]-time,set.list_time_long_g[1]-time,set.list_time_long_g,set.list_object_long_g);
                    }

                }
                else{
                    check_long_b(set.list_time_long_b[0]-time,set.list_time_long_b[1]-time,set.list_time_long_b,set.list_object_long_b);
                }   
            }
            else if(set.list_time_long_g.Count>=2&&set.list_time_long_g.Count%2==0)
            {
                check_long_g(set.list_time_long_g[0]-time,set.list_time_long_g[1]-time,set.list_time_long_g,set.list_object_long_g);
            }
        }
    }
    void check_txt_down(float notes_time,List<float> list_notestime,List<GameObject> list_notes){
        if (Mathf.Abs(notes_time)<0.04f) {
            remove(list_notestime,list_notes);
            Instantiate(Perfect_down, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            Score.Perfect++;
            Score.Combo++;
        }
        else if (Mathf.Abs(notes_time)<0.1f) {
            remove(list_notestime,list_notes);
            Instantiate(Great_down, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            Score.Great++;
            Score.Combo++;
        }
        else if (Mathf.Abs(notes_time)<0.2f) {
            remove(list_notestime,list_notes);
            Instantiate(Good_down, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            Score.Good++;
            Score.Combo=0;
        }
        else if (Mathf.Abs(notes_time)<0.3f) {
            remove(list_notestime,list_notes);
            Instantiate(Bad_down, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            Score.Bad++;
            Score.Combo=0;
        }
    }
    void check_long_b(float notes_time,float notes_time2,List<float> list_notestime,List<GameObject> list_notes)
    {
        time2=0;
        setting.button_long_down = true;
        check_txt_down(notes_time,list_notestime,list_notes);

        StartCoroutine(WaitUntil_b(notes_time2,list_notestime,list_notes));
    }
    void check_long_g(float notes_time,float notes_time2,List<float> list_notestime,List<GameObject> list_notes)
    {
        time2=0;
        setting.button_long_down = true;
        check_txt_down(notes_time,list_notestime,list_notes);

        StartCoroutine(WaitUntil_g(notes_time2,list_notestime,list_notes));
    }
    IEnumerator WaitUntil_b(float notes_time2,List<float> list_notestime,List<GameObject> list_notes){
        if(Input.GetKey(KeyCode.V)){
            yield return new WaitUntil(() => Input.GetKeyUp (KeyCode.V));
        }
        else if(Input.GetKey(KeyCode.N)){
            yield return new WaitUntil(() => Input.GetKeyUp (KeyCode.N));
        }
        setting.button_long_down = false;
        check_down2(notes_time2,list_notestime,list_notes);
    }
    IEnumerator WaitUntil_g(float notes_time2,List<float> list_notestime,List<GameObject> list_notes){
        if(Input.GetKey(KeyCode.V)){
            yield return new WaitUntil(() => Input.GetKeyUp (KeyCode.V));
        }
        else if(Input.GetKey(KeyCode.N)){
            yield return new WaitUntil(() => Input.GetKeyUp (KeyCode.N));
        }
        setting.button_long_down = false;
        check_down2(notes_time2,list_notestime,list_notes);
    }
    void check_down2(float notes_time2,List<float> list_notestime,List<GameObject> list_notes){
        notes_time2-=time2;
        if (Mathf.Abs(notes_time2)<0.08f) {
            remove(list_notestime,list_notes);
            Instantiate(Perfect_down, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            Score.Perfect++;
            Score.Combo++;
        }
        else if (Mathf.Abs(notes_time2)<0.14f) {
            remove(list_notestime,list_notes);
            Instantiate(Great_down, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            Score.Great++;
            Score.Combo++;
        }
        else if (Mathf.Abs(notes_time2)<0.24f) {
            remove(list_notestime,list_notes);
            Instantiate(Good_down, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
            Score.Good++;
            Score.Combo=0;
        }
        else if (Mathf.Abs(notes_time2)<0.3f) {
            remove(list_notestime,list_notes);
            Instantiate(Bad_down, new Vector3( 0,0,0), Quaternion.Euler (new Vector3(90, 180, 0)));
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
