using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {


   public static bool guiGen;

    [SerializeField] GameObject spawn;
    private void Start()
    {
      
        guiGen = true;
    }
    
    private void OnGUI()
    {
        if(guiGen==true)
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 30, 200, 60), "Generate Maze"))
        {
                Instantiate(spawn,transform.position,Quaternion.identity);guiGen = false;
        }

        if (GUI.Button(new Rect(Screen.width - 220, Screen.height - 100, 150, 45), "RESET"))
        {
            SceneManager.LoadScene("SampleScene");
        }
        
    }
}
