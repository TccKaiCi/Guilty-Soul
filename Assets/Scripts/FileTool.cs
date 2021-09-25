using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class FileTool : MonoBehaviour, IJson
{

    public void JsonWriter(string filename, Player.SavePack data)
    {
        string strOut = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + "/Save.json",strOut);
    }
     public Player.SavePack JsonReader(TextAsset saveFile)
    {
        AssetDatabase.Refresh();
        Player.SavePack pack = JsonUtility.FromJson<Player.SavePack>(saveFile.text);
        return pack;
    }
}
