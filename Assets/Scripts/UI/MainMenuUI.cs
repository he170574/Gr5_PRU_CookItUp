using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private Button aboutUsButton;
    [SerializeField] private Button backButton;
    private void Awake()
    {
        if (playButton != null)
            playButton.onClick.AddListener(() => { LoadScene("LobbyScene"); });

        if (quitButton != null)
            quitButton.onClick.AddListener(() => { Application.Quit(); });

        if (aboutUsButton != null)
            aboutUsButton.onClick.AddListener(() => { LoadScene("AboutUsScene"); });

        if (backButton != null)
            backButton.onClick.AddListener(() => { LoadScene("MainMenuScene"); });

        Time.timeScale = 1f;
    }

    private void LoadScene(string AboutUsScene)
    {
        SceneManager.LoadScene(AboutUsScene);
    }
}
