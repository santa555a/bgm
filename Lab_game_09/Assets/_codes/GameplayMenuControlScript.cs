using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayMenuControlScript : MonoBehaviour
{
    [SerializeField] Button _backButton;
    [SerializeField] Button _nextButton;
    // Start is called before the first frame update
    void Start()
    {
        _backButton.onClick.AddListener(delegate { BackToMainMenuButtonClick(_backButton); });
       //_nextButton.onClick.AddListener(delegate { NextToGameplayButtonClick(_nextButton); });
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void BackToMainMenuButtonClick(Button button)
    {
            SingletonSoundManager.Instance.BGMSource.Stop();
        SceneManager.UnloadSceneAsync("SceneGameplay");
        SceneManager.LoadScene("SceneMainMenu");
        SingletonGameManager.Instance.GameScore++;
    }

    public void NextToGameplayButtonClick(Button button)
    {
            SingletonSoundManager.Instance.BGMSource.Play();
        SceneManager.UnloadSceneAsync("SceneGameplay");
        SceneManager.LoadScene("SceneGameplay2");
        SingletonGameManager.Instance.GameScore++;
    }
}
