using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.UI;

public class RowsColmns : MonoBehaviour {


    GameObject spawn;
    Text t1,t2;
    int r, c;
    private void Start()
    {
        t1 = transform.GetChild(0).GetComponent<Text>();
        t2 = transform.GetChild(1).GetComponent<Text>();

        
    }
    private void Update()
    {
        if (UIManager.guiGen == false)
        {
            spawn = GameObject.FindGameObjectWithTag("Respawn");
            r = spawn.GetComponent<MazeLoader>().mazeRows;
            c = spawn.GetComponent<MazeLoader>().mazeColumns;
            t1.text = "Rows: " + r.ToString();
            t2.text = "Columns: " + c.ToString();
        }
     
        
    }
}
