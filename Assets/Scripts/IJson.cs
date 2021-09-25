using System.Collections;
using System.Collections.Generic;
using UnityEngine;
interface IJson 
{
    public void JsonWriter(string filename, Player.SavePack data);
    public  Player.SavePack JsonReader(TextAsset saveFile);
}
