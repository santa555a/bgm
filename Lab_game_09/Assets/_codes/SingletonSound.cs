using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonSound : Singleton<SingletonSound>
{
    protected SingletonSound() { }

    public string ClassName { get; } = "SingletonSound";

    public int Sound { get; set; } = 0;
}
