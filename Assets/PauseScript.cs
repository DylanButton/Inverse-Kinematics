using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public static bool Paused = false;
    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(Paused){
                Resume();
            }else
            {
                Pause();
            }
        }
    }
    void Start () {
        PauseMenuUI.SetActive(false);
 }
    public void Resume (){
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }
    void Pause (){
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        Paused = true;
    }

    public void LoadMenu(){
        SceneManager.LoadScene(0);
        Debug.Log("Loading Menu...");
    }
}
