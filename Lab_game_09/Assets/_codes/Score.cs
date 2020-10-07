using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        score.text = SingletonGameManager.Instance.GameScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
