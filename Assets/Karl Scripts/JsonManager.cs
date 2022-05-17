using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class JsonManager: MonoBehaviour
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

    public List<List<float>> GetpuzzleList()
    {
        string saveFile = "Assets/Karl Scripts/Text/JSONText.txt";
        string fileContents = File.ReadAllText(saveFile);
        PuzzleList puzzleListInJSON = JsonUtility.FromJson<PuzzleList>(fileContents);
        List<List<float>> returnList = new List<List<float>>();
        foreach (Puzzle puzzle in puzzleListInJSON.puzzles)
        {
            List<float> timesList = new List<float>();
            foreach (float item in puzzle.times)
            {
                timesList.Add(item);
            }
            returnList.Add(timesList);
        }
        return returnList;
    }
    public void SaveToJSON(Puzzle puzzleObj)
    {
        string saveFile = "Assets/Karl Scripts/Text/JSONText.txt";
        string fileContents = File.ReadAllText(saveFile);
        PuzzleList puzzleListInJSON = JsonUtility.FromJson<PuzzleList>(fileContents);
        puzzleListInJSON.puzzles.Add(puzzleObj);
        string jsonToSave = JsonHelper.ToJson(puzzleListInJSON.puzzles.ToArray());
        File.WriteAllText("Assets/Karl Scripts/Text/JSONText.txt", jsonToSave);
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
    }

}
