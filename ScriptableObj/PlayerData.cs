using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStatus", menuName = "Data_PlayerStorage/PlayerStatus")]

public class PlayerData : ScriptableObject
{
    public string PlayerName;
    public int Player_maxHp;
    public int Player_currentHp;
    //public bool isStart=true;
    //[TextArea]
    //public string itemInfo;

}
