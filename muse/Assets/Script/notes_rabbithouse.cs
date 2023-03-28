using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notes_rabbithouse : MonoBehaviour
{
    private float bpm;
    private float speed;
    private float quarter_position;
    public List<GameObject> list_object_r = new List<GameObject>();
    public List<float> list_time_r = new List<float>();
    public List<GameObject> list_object_b = new List<GameObject>();
    public List<float> list_time_b = new List<float>();
    public List<GameObject> list_object_g = new List<GameObject>();
    public List<float> list_time_g = new List<float>();
    public List<GameObject> list_object_y = new List<GameObject>();
    public List<float> list_time_y = new List<float>();
    // Start is called before the first frame update
    void Start()
    {
        bpm = setting.bpm;
        speed = setting.speed;
        quarter_position = 60/bpm*speed;

        GameObject obj_r = (GameObject)Resources.Load ("notes_r");
        GameObject obj_b = (GameObject)Resources.Load ("notes_b");
        GameObject obj_g = (GameObject)Resources.Load ("notes_g");
        GameObject obj_y = (GameObject)Resources.Load ("notes_y");

        notes_b(obj_b,0,0,0,0);
        notes_r(obj_r,0,2,0,0);
        notes_three_r(obj_r,1,0,0,0);
        notes_three_r(obj_r,1,0,0,1);
        notes_three_r(obj_r,1,0,0,2);
        
    }

    void notes_r(GameObject obj,float bar, float quarter,float eighth ,float sixteenth)
    {
        float position = 5f*speed+quarter_position*bar*4+quarter_position*quarter+quarter_position*eighth/2+quarter_position*sixteenth/4-5f;
        GameObject clone = Instantiate(obj, new Vector3( position, 4.5f, -0.1f), Quaternion.Euler (new Vector3(90, 180, 0)));
        list_object_r.Add(clone);
        list_time_r.Add((position+5f)/speed+5f);
    }
    void notes_y(GameObject obj,float bar, float quarter,float eighth ,float sixteenth)
    {
        float position = 5f*speed+quarter_position*bar*4+quarter_position*quarter+quarter_position*eighth/2+quarter_position*sixteenth/4-5f;
        GameObject clone = Instantiate(obj, new Vector3( position, 4.5f, -0.1f), Quaternion.Euler (new Vector3(90, 180, 0)));
        list_object_y.Add(clone);
        list_time_y.Add((position+5f)/speed+5f);
    }
    void notes_g(GameObject obj,float bar, float quarter,float eighth ,float sixteenth)
    {
        float position = 5f*speed+quarter_position*bar*4+quarter_position*quarter+quarter_position*eighth/2+quarter_position*sixteenth/4-5f;
        GameObject clone = Instantiate(obj, new Vector3( position, 1.5f, -0.1f), Quaternion.Euler (new Vector3(90, 180, 0)));
        list_object_g.Add(clone);
        list_time_g.Add((position+5f)/speed+5f);
    }
    void notes_b(GameObject obj,float bar, float quarter,float eighth ,float sixteenth)
    {
        float position = 5f*speed+quarter_position*bar*4+quarter_position*quarter+quarter_position*eighth/2+quarter_position*sixteenth/4-5f;
        GameObject clone = Instantiate(obj, new Vector3( position, 1.5f, -0.1f), Quaternion.Euler (new Vector3(90, 180, 0)));
        list_object_b.Add(clone);
        list_time_b.Add((position+5f)/speed+5f);
    }

    void notes_three_r(GameObject obj,float bar, float quarter,float eighth ,float sixteenth)
    {
        float position = 5f*speed+quarter_position*bar*4+quarter_position*quarter*2/3+quarter_position*eighth/3+quarter_position*sixteenth/6-5f;
        GameObject clone = Instantiate(obj, new Vector3( position, 4.5f, -0.1f), Quaternion.Euler (new Vector3(90, 180, 0)));
        list_object_r.Add(clone);
        list_time_r.Add((position+5f)/speed+5f);
    }
    void notes_three_y(GameObject obj,float bar, float quarter,float eighth ,float sixteenth)
    {
        float position = 5f*speed+quarter_position*bar*4+quarter_position*quarter*2/3+quarter_position*eighth/3+quarter_position*sixteenth/6-5f;
        GameObject clone = Instantiate(obj, new Vector3( position, 4.5f, -0.1f), Quaternion.Euler (new Vector3(90, 180, 0)));
        list_object_y.Add(clone);
        list_time_y.Add((position+5f)/speed+5f);
    }
    void notes_three_g(GameObject obj,float bar, float quarter,float eighth ,float sixteenth)
    {
        float position = 5f*speed+quarter_position*bar*4+quarter_position*quarter*2/3+quarter_position*eighth/3+quarter_position*sixteenth/6-5f;
        GameObject clone = Instantiate(obj, new Vector3( position, 1.5f, -0.1f), Quaternion.Euler (new Vector3(90, 180, 0)));
        list_object_g.Add(clone);
        list_time_g.Add((position+5f)/speed+5f);
    }
    void notes_three_b(GameObject obj,float bar, float quarter,float eighth ,float sixteenth)
    {
        float position = 5f*speed+quarter_position*bar*4+quarter_position*quarter*2/3+quarter_position*eighth/3+quarter_position*sixteenth/6-5f;
        GameObject clone = Instantiate(obj, new Vector3( position, 1.5f, -0.1f), Quaternion.Euler (new Vector3(90, 180, 0)));
        list_object_b.Add(clone);
        list_time_b.Add((position+5f)/speed+5f);
    }

}
