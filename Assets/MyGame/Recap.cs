using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Recap : MonoBehaviour
{
    // public Button greenButton;
    public Button[] buttons;
    Queue<Color> colorStack = new Queue<Color>();
    

    public Button switchButton;

    bool firstButtonWasClicked = false;
    bool secondButtonWasClicked = false;
    bool thirdButtonWasClicked = false;


    // Start is called before the first frame update
    void Start()
    {
        colorStack.Enqueue(Color.red);
        colorStack.Enqueue(Color.blue);
        colorStack.Enqueue(Color.green);

        foreach (var button in buttons)
            button.GetComponent<Image>().color = colorStack.Dequeue();

        switchButton.interactable = false;
    }

    public void ChangeColor(Button button)
    {
        button.GetComponent<Image>().color = Random.ColorHSV();
    }

    public void ClickStatus (int buttonNumber)
    {
        if(buttonNumber == 0)
            firstButtonWasClicked = true;
     
        if (buttonNumber == 1)
            secondButtonWasClicked = true;

        if (buttonNumber == 2)
            thirdButtonWasClicked = true;

        if (firstButtonWasClicked && secondButtonWasClicked && thirdButtonWasClicked)
            switchButton.interactable = true;
    }
 
    public void SwitchTheScene()
    {
        SceneManager.LoadScene(1);
    }
}

  

