using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Pallet", menuName ="PHUnity/Pallet")]
public class Pallet : ScriptableObject 
{
    public string id;
    public List<kvpColor> colors;
}


[System.Serializable]
public class kvpColor
{
    public string key;
    public Color32 value;
}
