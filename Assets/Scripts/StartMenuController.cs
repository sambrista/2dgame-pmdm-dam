using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnStartClick()
    {
        SceneManager.LoadScene("SampleScene");
        MusicManager.PlayBackgroundMusic();
    }
    public void OnExitClick(){
        #if UNITY_Editor
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
}
