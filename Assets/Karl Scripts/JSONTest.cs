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
    }

    [System.Serializable]
    public class PuzzleList
    {
        public List<Puzzle> puzzles;
    }

    //public Puzzle myPuzzle = new Puzzle();
    //public PuzzleList myPuzzleList = new PuzzleList();

    public void outPutJSON()
    {
        Puzzle puzzle1 = new Puzzle();
        puzzle1.name = "TEst";
        puzzle1.time = 0.1f;

        string json = JsonUtility.ToJson(puzzle1);

        PuzzleList puzzleListInJSON = JsonUtility.FromJson<PuzzleList>(textJSON.text);

        puzzleListInJSON.puzzles.Add(puzzle1);

        foreach (Puzzle puzzle in puzzleListInJSON.puzzles)
        {
            Debug.Log(JsonUtility.ToJson(puzzle));
        }

        string jsonToSave = JsonHelper.ToJson(puzzleListInJSON.puzzles.ToArray()); 
        File.WriteAllText("Assets/Karl Scripts/Text/JSONText.txt", jsonToSave);
    }

    private void Start()
    {


        outPutJSON();

    }
}
