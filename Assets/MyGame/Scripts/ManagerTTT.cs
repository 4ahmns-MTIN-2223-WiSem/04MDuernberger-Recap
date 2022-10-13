using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerTTT : MonoBehaviour
{
    public TicTacToeElem[] game; //Array aus Elementen
    public bool whichPlayer = false; // false = Player X, true = Player O
    public Image DotLeft;
    public Image DotRight;
    public bool winStatus = false;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < game.Length; i++)
        {
            game[i].GetComponent<TicTacToeElem>().myState = TTTState.W;

            DotLeft.enabled = true;
            DotRight.enabled = false;
        }

    }


    public void WinnerCheck(TTTState Player, int one, int two, int three)
    {
       


            if (game[one].GetComponent<TicTacToeElem>().myState == Player && game[two].GetComponent<TicTacToeElem>().myState == Player && game[three].GetComponent<TicTacToeElem>().myState == Player)
            {
                winStatus = true;
                game[one].GetComponent<Image>().color = Color.green;
                game[two].GetComponent<Image>().color = Color.green;
                game[three].GetComponent<Image>().color = Color.green;


            }

        

        if (winStatus)
        {
            Debug.Log("Player " + Player + " won");
            DotLeft.enabled = false;
            DotRight.enabled = false;
        }

    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
