using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class State : MonoBehaviour
{
    public List<GameObject> textList = new List<GameObject>();
    PlayerInput playerInput;

    public UILineRenderer line;

    bool[] pressedList = new bool[16];

    List<string> actionList = new List<string>();

    bool timerIsRunning = false;
    public float timeCounter;
    XBOXAdapter xboxAdp;
    int currentPuzszle = 0;
    //int timerText = 0;

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
        if (timerIsRunning )
        {
            Debug.Log("Main: " + (currentPuzszle));
            timeCounter += Time.deltaTime;
            DisplayTime(timeCounter, textList[currentPuzszle]);

            //If counts up to 1 hour the game should end 
        }
    }


    void TimmerChange()
    {
        StateChange(textList[currentPuzszle]);
        
        if (timerIsRunning)
        {
            currentPuzszle++;
            StateChange(textList[currentPuzszle]);
        }
        timeCounter = 0;
        timerIsRunning = true;
    }

    public void ButtonInput(InputAction.CallbackContext ctx)
    {
        //It's posible to start another event, change for next time, 
        //Should Add point in line list for each task done. 
        if (ctx.performed)
        {
            for (int i = 0; i < actionList.Count; i++)
            {
                if (ctx.action.name == actionList[i] && pressedList[i] == false)
                {
                    TimmerChange();
                    pressedList[i] = true;
                }
            }
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
