using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//need to import SceneManagement to be abale to use scene manager
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneLoader(int SceneIndex)
    {
        //loading scne using scene index value which you can set
        //go to file -> Bulid setting -> make shure all of your sences
        //have been added by clicking on Add Open Scenes
        //On the right side you can see a number next yo your sence name
        //That number is SceneIndex number
        SceneManager.LoadScene(SceneIndex);
    }
}
