using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum TTTState
{
    W,
    O,
    X
}

public class TicTacToeElem : MonoBehaviour
{
    public TTTState myState = TTTState.W;
    public TMP_Text text;


    

    // Start is called before the first frame update
    void Start()
    {
        text.enabled = false;       
        text.text = "";
    }

    public void OnMouseDown()
    {
        var manager = GameObject.Find("Manager").GetComponent<ManagerTTT>();
        if (manager.winStatus)
        {
            return;
        }
        else if (manager.whichPlayer == true)
        {
            text.text = "O";
            myState = TTTState.O;
            manager.DotRight.enabled = false;
            manager.DotLeft.enabled = true;

        }
        else
        {
            text.text = "X";
            myState = TTTState.X;

            manager.DotRight.enabled = true;
            manager.DotLeft.enabled = false;

        }

        manager.WinnerCheck(myState, 0, 1, 2);
        manager.WinnerCheck(myState, 3, 4, 5);
        manager.WinnerCheck(myState, 6, 7, 8);
        manager.WinnerCheck(myState, 0, 3, 6);
        manager.WinnerCheck(myState, 1, 4, 7);
        manager.WinnerCheck(myState, 2, 5, 8);
        manager.WinnerCheck(myState, 0, 4, 8);
        manager.WinnerCheck(myState, 2, 4, 6);

        text.enabled = true;
        
        manager.whichPlayer  = !manager.whichPlayer;
       

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
