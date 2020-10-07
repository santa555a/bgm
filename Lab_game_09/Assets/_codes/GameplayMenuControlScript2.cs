using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayMenuControlScript2 : MonoBehaviour
{
    [SerializeField] Button _backButton;
    // Start is called before the first frame update
    void Start()
    {
        _backButton.onClick.AddListener(delegate { BackToMainMenuButtonClick(_backButton); });
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void BackToMainMenuButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneGameplay2");
        SceneManager.LoadScene("SceneMainMenu");
        SingletonSoundManager.Instance.BGMSource.Stop();
        SingletonGameManager.Instance.GameScore++;
    }
}
