using UnityEngine;
using System.Collections;

public class MazeLoader : MonoBehaviour {
	public int mazeRows, mazeColumns;
	public GameObject wall;
	public float size = 2f;

	private MazeCell[,] mazeCells;

	// Use this for initialization
	void Start () {

        mazeRows = 20;
        mazeColumns = 15;
		InitializeMaze ();

        Invoke("mazeGenerate",1f);
	}

    void mazeGenerate()
    {
        HuntAndKillMazeAlgorithm ma = new HuntAndKillMazeAlgorithm(mazeCells);
         
    }

	private void InitializeMaze() {
        
        ///\\\
        mazeRows = Random.Range(3, mazeRows);
        mazeColumns = Random.Range(3, mazeColumns);
        mazeCells = new MazeCell[mazeRows,mazeColumns];
        ///\\\

		for (int r = 0; r < mazeRows; r++) {
			for (int c = 0; c <  mazeColumns; c++) {

				mazeCells [r, c] = new MazeCell ();

				if (c == 0) {
					mazeCells[r,c].westWall = Instantiate (wall, new Vector3 (r*size, (c*size) - (size/2f),0f), Quaternion.identity) as GameObject;		
                    mazeCells[r, c].westWall.transform.parent = gameObject.transform;
				}

				mazeCells [r, c].eastWall = Instantiate (wall, new Vector3 (r*size, (c*size) + (size/2f), 0f), Quaternion.identity) as GameObject;
				mazeCells[r, c].eastWall.transform.parent = gameObject.transform;

                if (r == 0) {
					mazeCells [r, c].northWall = Instantiate (wall, new Vector3 ((r*size) - (size/2f), c*size, 0f), Quaternion.identity) as GameObject;
				    mazeCells [r, c].northWall.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
                    mazeCells[r, c].northWall.transform.parent = gameObject.transform;
                }

				mazeCells[r,c].southWall = Instantiate (wall, new Vector3 ((r*size) + (size/2f),c*size, 0f), Quaternion.identity) as GameObject;
				mazeCells [r, c].southWall.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
                mazeCells[r, c].southWall.transform.parent = gameObject.transform;
            }
		}

        transform.position = new Vector3(-mazeRows/2+(0.5f),-mazeColumns/2+(0.5f),0f) ;
	}
}
