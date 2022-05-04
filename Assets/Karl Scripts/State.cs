using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class State : MonoBehaviour
{
    public List<GameObject> textList = new List<GameObject>();
    //public InputActionMap actionMap;

    bool[] pressedList = new bool[16];

    List<string> inputList = new List<string>();

    bool timerIsRunning = false;
    public float timeCounter;
    XBOXAdapter xboxAdp;
    int currentPuzszle = 0;

    // Start is called before the first frame update
    private void Awake()
    {
        foreach (var item in actionMap.actions)
        {
            Debug.Log(item.name);
        }
        xboxAdp = new XBOXAdapter();
    }

    private void Update()
    {
        //if (timerIsRunning)
        //{
        //    timeCounter += Time.deltaTime;
        //    DisplayTime(timeCounter, textList[currentPuzszle]);
        //    //If counts up to 1 hour the game ends. 
        //}
    }


    void TimmerChange()
    {
        StateChange(textList[currentPuzszle]);
        if (timerIsRunning == true)
        {
            currentPuzszle++;
            StateChange(textList[currentPuzszle]);
        }

        timeCounter = 0;
        timerIsRunning = true;
        
    }

    public void ButtonInput(InputAction.CallbackContext ctx)
    {
        string action = "";

        if (ctx.performed)
        {
            

            //action = ctx.action.name;

            //if (inputList.Count > 1)
            //{
            //    foreach (string item in inputList)
            //    {
            //        if (action != item)
            //        {
            //            inputList.Add(action);
            //        }
            //    }
            //}
            //else if (inputList.Count > 0)
            //{
            //    inputList.Add(action);
            //}

            //foreach (string item in inputList)
            //{
            //    Debug.Log(item);
            //}
            //Debug.Log("I GOT PRESSED " + ctx.action.name);
            //TimmerChange();
            //currentPuzszle++;
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
