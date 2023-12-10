using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartMenu : MonoBehaviour
{
    [Header("UI Pages")]
    public GameObject mainMenu;
    public GameObject options;
    public GameObject about;
    public GameObject levels;

    [Header("Main Menu Buttons")]
    public Button startButton;
    public Button optionButton;
    public Button aboutButton;
    public Button quitButton;
    public Button levelButton;

    [Header("Level Buttons")]
    public Button Level1Button;
    public Button Level2Button;
    public Button Level3Button;
    public Button Level4Button;
    public Button Level5Button;


    public List<Button> returnButtons;

    // Start is called before the first frame update
    void Start()
    {
        EnableMainMenu();

        //Hook events
        startButton.onClick.AddListener(StartGame);
        levelButton.onClick.AddListener(EnableLevels);
        optionButton.onClick.AddListener(EnableOption);
        aboutButton.onClick.AddListener(EnableAbout);
        quitButton.onClick.AddListener(QuitGame);
        Level1Button.onClick.AddListener(ChangeLevelto1);
        Level2Button.onClick.AddListener(ChangeLevelto2);
        Level3Button.onClick.AddListener(ChangeLevelto3);
        Level4Button.onClick.AddListener(ChangeLevelto4);
        Level5Button.onClick.AddListener(ChangeLevelto5);
        foreach (var item in returnButtons)
        {
            item.onClick.AddListener(EnableMainMenu);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(2);
    }
    
    public void HideAll()
    {
        mainMenu.SetActive(false);
        levels.SetActive(false);
        options.SetActive(false);
        about.SetActive(false);
    }

    public void EnableMainMenu()
    {
        mainMenu.SetActive(true);
        options.SetActive(false);
        levels.SetActive(false);
        about.SetActive(false);
    }
    public void EnableLevels()
    {
        mainMenu.SetActive(false);
        levels.SetActive(true);
        options.SetActive(false);
        about.SetActive(false);
    }
    public void EnableOption()
    {
        mainMenu.SetActive(false);
        options.SetActive(true);
        about.SetActive(false);
    }
    public void EnableAbout()
    {
        mainMenu.SetActive(false);
        options.SetActive(false);
        about.SetActive(true);
    }
    public void ChangeLevelto1()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToScene(1);
    }
    public void ChangeLevelto2()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToScene(2);
    }
    public void ChangeLevelto3()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToScene(3);
    }
    public void ChangeLevelto4()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToScene(4);
    }
    public void ChangeLevelto5()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToScene(5);
    }
}
