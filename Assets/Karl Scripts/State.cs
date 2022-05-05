using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class State : MonoBehaviour
{
    public List<GameObject> textList = new List<GameObject>();
    PlayerInput playerInput;

    bool[] pressedList = new bool[16];

    List<string> actionList = new List<string>();

    bool timerIsRunning = false;
    public float timeCounter;
    XBOXAdapter xboxAdp;
    int currentPuzszle;

    // Start is called before the first frame update
    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        foreach (var item in playerInput.actions)
        {
            actionList.Add(item.name);
        }
        xboxAdp = new XBOXAdapter();
    }

    private void Update()
    {
        if (timerIsRunning)
        {
            timeCounter += Time.deltaTime;
            DisplayTime(timeCounter, textList[currentPuzszle]);
            //If counts up to 1 hour the game ends. 
        }
    }


    void TimmerChange(int index)
    {
        StateChange(textList[index]);
        if (timerIsRunning == true)
        {
            currentPuzszle++;
            StateChange(textList[index]);
        }

        timeCounter = 0;
        timerIsRunning = true;
        
    }

    public void ButtonInput(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            for (int i = 0; i < actionList.Count; i++)
            {
                if (ctx.action.name == actionList[i] && pressedList[i] == false)
                {
                    if (i == currentPuzszle)
                    {
                        //Debug.Log("I GOT PRESSED BY " + actionList[i]);
                        TimmerChange(i);
                        //currentPuzszle++;
                        pressedList[i] = true;
                    }
                    
                }
            }
            Debug.Log(currentPuzszle);
        }
    }

    // Change Color
    private void StateChange(GameObject changeColor)
    {
        if (changeColor.GetComponent<Image>().color == new Color32(255, 255, 255, 255))
        {
            changeColor.GetComponent<Image>().color = new Color32(255, 255, 0, 255);
        }
        else if (changeColor.GetComponent<Image>().color == new Color32(255, 255, 0, 255))
        {
            changeColor.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
        }

    }

    //Displey Time
    void DisplayTime(float timeToDisplay, GameObject obj)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        obj.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    //Enable and Disable
    void OnEnable()
    {
        xboxAdp.Signal.Enable();
    }
    private void OnDisable()
    {
        xboxAdp.Signal.Disable();
    }
}
