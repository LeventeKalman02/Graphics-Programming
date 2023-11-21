using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update

    public string SceneName;

    // Update is called once per frame
    void Update()
    {
        //load other scene when the "C" key is pressed
        //switches to and from both scenes
        if (Input.GetKeyUp(KeyCode.C))
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
