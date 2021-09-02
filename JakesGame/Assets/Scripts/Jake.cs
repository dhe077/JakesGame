using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jake : MonoBehaviour
{
    public GameObject board;
    //board size variable
    private float ratio = 5.0f / 4.0f;
    private float scale = 0.2285f;
    private float board_size = 10.0f;
    //array
    private GameObject[,] position = new GameObject[10, 10];
    private int[,] visit = new int[10, 10];
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = Instantiate(board, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Used to share scale variable
    public float GetRatio()
    {
        return ratio;
    }
    public float GetScale()
    {
        return scale;
    }
    public int GetBoardSizeI()
    {
        return (int)board_size;
    }
    public float GetBoardSizeF()
    {
        return board_size;
    }

    //public GameObject Create(string name, int x, int y)
    //{
    //    //GameObject obj = Instantiate(go_piece, new Vector3(0, 0, -1), Quaternion.identity);
    //    Go_man_O gm = obj.GetComponent<Go_man_O>();

    //    gm.name = name;
    //    gm.SetXBoard(x);
    //    gm.SetYBoard(y);
    //    gm.Activate();

    //    SetPosition(obj);
    //    //DFS(obj);

    //    return obj;

    //}
}
