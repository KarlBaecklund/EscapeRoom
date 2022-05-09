using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class JSONTest: MonoBehaviour
{
    public TextAsset textJSON;

    [System.Serializable]
    public class Puzzle
    {
        public string name;
        public float time;
        public int index;
    }

    [System.Serializable]
    public class PuzzleList
    {
        public Puzzle[] puzzle;
    }


    public Puzzle myPuzzle = new Puzzle();
    public PuzzleList myPuzzleList = new PuzzleList();

    public void outPutJSON()
    {
        string strOutPut = JsonUtility.ToJson(myPuzzleList);

        File.WriteAllText("Assets/Karl Scripts/Text/JSONText.txt", strOutPut);
    }

    private void Start()
    {
        outPutJSON();

    }
}
