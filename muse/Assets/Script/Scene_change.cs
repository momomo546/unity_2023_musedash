using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_change : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey){
            SceneManager.LoadScene("Game_Scene");
        }
    }
}
