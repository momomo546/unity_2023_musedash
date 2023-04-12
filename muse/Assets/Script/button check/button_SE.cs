using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_SE : MonoBehaviour
{
    [SerializeField] private AudioSource SE;
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.F)) {
            Play_SE();
            if(setting.button_long_up == true){
                StartCoroutine(WaitUntil());
            }
        }
        if (Input.GetKeyDown (KeyCode.V)) {
            Play_SE();
            if(setting.button_long_down == true){
                StartCoroutine(WaitUntil());
            }
        }
        if (Input.GetKeyDown (KeyCode.J)) {
            Play_SE();
            if(setting.button_long_up == true){
                StartCoroutine(WaitUntil());
            }
        }
        if (Input.GetKeyDown (KeyCode.N)) {
            Play_SE();
            if(setting.button_long_down == true){
                StartCoroutine(WaitUntil());
            }
        }
    }
    IEnumerator WaitUntil(){
        if(Input.GetKey(KeyCode.V)){
            yield return new WaitUntil(() => Input.GetKeyUp (KeyCode.V));
        }
        else if(Input.GetKey(KeyCode.N)){
            yield return new WaitUntil(() => Input.GetKeyUp (KeyCode.N));
        }
        else if(Input.GetKey(KeyCode.J)){
            yield return new WaitUntil(() => Input.GetKeyUp (KeyCode.J));
        }
        else if(Input.GetKey(KeyCode.F)){
            yield return new WaitUntil(() => Input.GetKeyUp (KeyCode.F));
        }
        setting.button_long_up = false;
        setting.button_long_down = false;
    }
    void Play_SE()
    {
        SE.Play();
    }
}
