using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingletonGameManager : Singleton<SingletonGameManager>
{
    protected SingletonGameManager() { }

    public string ClassName { get; } = "SingletonGameManager";

    public int GameScore { get; set; } = 0;

}
