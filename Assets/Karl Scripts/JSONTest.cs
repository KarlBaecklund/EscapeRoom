using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class JSONTest: MonoBehaviour
{
    public TextAsset textJSON;
    public UILineRenderer Line;

    [System.Serializable]
    public class Puzzle
    {
        public string name;
        public float[] times = new float[5];
    }

    [System.Serializable]
    public class PuzzleList
    {
        public List<Puzzle> puzzles;
    }



    public void outPutJSON()
    {
        PuzzleList puzzleListInJSON = JsonUtility.FromJson<PuzzleList>(textJSON.text);
        string jsonToSave = JsonHelper.ToJson(puzzleListInJSON.puzzles.ToArray());
        Debug.Log(jsonToSave);
        File.WriteAllText("Assets/Karl Scripts/Text/JSONText.txt", jsonToSave);
    }
    //Tar in index och tid 

    public void SaveToJSON(Puzzle puzzleObj)
    {
        string saveFile = "Assets/Karl Scripts/Text/JSONText.txt";
        string fileContents = File.ReadAllText(saveFile);
        PuzzleList puzzleListInJSON = JsonUtility.FromJson<PuzzleList>(fileContents);
        puzzleListInJSON.puzzles.Add(puzzleObj);
        string jsonToSave = JsonHelper.ToJson(puzzleListInJSON.puzzles.ToArray());
        File.WriteAllText("Assets/Karl Scripts/Text/JSONText.txt", jsonToSave);
    }
    public void Average(Puzzle puzzleObj)
    {
        Line.AddPoint(new Vector2(1 * 57.5f, 500f / 20f));
        //for (int i = 1; i < puzzleObj.times.Length; i++)
        //{

        //}


    }
    public void AddToJSON(List<float> timeList)
    {
        Puzzle puzzle = new Puzzle();
        for (int i = 0; i < puzzle.times.Length; i++)
        {
            puzzle.times[i] = timeList[i];
        }
        puzzle.name = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy | HH:mm");
        SaveToJSON(puzzle);
        Average(puzzle);
    }

}
