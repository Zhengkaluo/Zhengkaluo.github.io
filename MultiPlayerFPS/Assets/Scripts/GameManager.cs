
using UnityEngine;
using System.Collections.Generic;
public class GameManager : MonoBehaviour
{
    private const string PLAYER_ID_PREFIX = "Player ";

    private static Dictionary<string, Player> PlayersDictionary = new Dictionary<string, Player>();

    public static void RegisterPlayer(string _NetID, Player _Player)
    {
        string _PlayerID = PLAYER_ID_PREFIX + _NetID;
        PlayersDictionary.Add(_PlayerID, _Player);
        _Player.transform.name = _PlayerID;
    }

    public static void UnRegisterPlayer(string _PlayerID)
    {
        PlayersDictionary.Remove(_PlayerID);
    }

    public static Player GetPlayer(string _PlayerID)
    {
        return PlayersDictionary[_PlayerID];
    }

    //void OnGUI()
    //{
    //    GUILayout.BeginArea(new Rect(200, 200, 300, 500));
    //    GUILayout.BeginVertical();

    //    foreach(string _PlayerID in PlayersDictionary.Keys)
    //    {
    //        GUILayout.Label(_PlayerID + " - " + GetPlayer(_PlayerID).transform.name);
    //    }

    //    GUILayout.EndVertical();
    //    GUILayout.EndArea();
    //}
}