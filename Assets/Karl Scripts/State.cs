using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class State : MonoBehaviour
{
    public List<GameObject> textList = new List<GameObject>();
    PlayerInput playerInput;

    JsonManager jsonManager;

    public UILineRenderer Line;
    public UILineRenderer Line2;


    bool[] pressedList = new bool[6];

    List<string> actionList = new List<string>();
    List<float> timeList = new List<float>();

    bool timerIsRunning = false;
    public float timeCounter;
    XBOXAdapter xboxAdp;
    int currentIndex;
    int lastIndex;
    //int timerText = 0;

    // Start is called before the first frame update
    private void Awake()
    {
        countAverage();

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
            //Debug.Log("Main: " + (currentPuzszle));
            timeCounter += Time.deltaTime * 60;
            
            DisplayTime(timeCounter, textList[currentIndex]);

            //If counts up to 1 hour the game should end 
        }
    }

    public void countAverage()
    {
        jsonManager = new JsonManager();
        int sizeToDiv = 0;
        float sumOfList = 0;
        float sum = 0;
        List<List<float>> timeList2d = jsonManager.GetpuzzleList();
        for (int j = 0; j < 5; j++) //Hård kodat yes i know
        {
            for (int i = 0; i < timeList2d.Count; i++)
            {
                sumOfList += timeList2d[i][j];

            }
            sizeToDiv = timeList2d.Count;
            sum = sumOfList / sizeToDiv;
            Line2.AddPoint(new Vector2((j + 2)*57.5f, sum / 20));
        }
        
        
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
                    //Debug.Log("Current: " + currentIndex + " Name: " + ctx.action.name);
                    if (i >= 1)
                    {
                        if (ctx.action.name == actionList[actionList.Count - 1])
                        {
                            jsonManager = new JsonManager();

                            currentIndex = i;
                            Line.AddPoint(new Vector2((currentIndex + 1) * 57.5f, timeCounter / 20));
                            timeList.Add(timeCounter);
                            StateChange(textList[currentIndex]);
                            StateChange(textList[lastIndex]);
                            DisplayTime(timeCounter, textList[currentIndex]);
                            StateChange(textList[currentIndex]);
                            
                            timerIsRunning = false;

                            jsonManager.AddToJSON(timeList);
                            //UnityEditor.EditorApplication.isPlaying = false;
                        }
                        else
                        {
                            //Debug.Log("YOU ARE HERE");
                            currentIndex = i;
                            StateChange(textList[lastIndex]);
                            pressedList[currentIndex] = true;
                            timeList.Add(timeCounter);
                            currentIndex++;
                            StateChange(textList[currentIndex]);
                            Line.AddPoint(new Vector2((currentIndex) * 57.5f, timeCounter / 20));
                            lastIndex = currentIndex;
                        }
                    }
                    else
                    {
                        currentIndex = i;
                        
                        timerIsRunning = true;
                        StateChange(textList[currentIndex]);
                        StateChange(textList[currentIndex]);
                        pressedList[currentIndex] = true;
                        currentIndex++;
                        StateChange(textList[currentIndex]);
                        lastIndex = currentIndex;
                    }
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
        obj.transform.GetChild(1).gameObject.GetComponent<Text>().text = string.Format("{0:00}:{1:00}", minutes, seconds);
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
