using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabloFarkiUI : MonoBehaviour
{
    [Header("UI Pages")]
    public GameObject levelMenu;
    public GameObject selectLevel;

    [Header("Main Menu Buttons")]
    public Button nextButton;
    public Button restartButton;
    public Button mainMenuButton;
    public Button selectLevelButton;

    [Header("Level Index")]
    public int nextIndex;
    public int currentIndex;
    public List<Button> returnButtons;
    // Start is called before the first frame update
    void Start()
    {
        EnableLevelMenu();

        nextButton.onClick.AddListener(NextLevel);
        restartButton.onClick.AddListener(RestartLevel);
        mainMenuButton.onClick.AddListener(ReturnToMain);
        selectLevelButton.onClick.AddListener(SelectLevels);

        foreach (var item in returnButtons)
        {
            item.onClick.AddListener(EnableLevelMenu);
        }
        levelMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HideAll()
    {
        levelMenu.SetActive(false);
        selectLevel.SetActive(false);
    }

    public void EnableLevelMenu()
    {
        levelMenu.SetActive(true);
        selectLevel.SetActive(false);

    }
    public void SelectLevels()
    {
        levelMenu.SetActive(false);
        selectLevel.SetActive(true);
    }
    public void RestartLevel()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(currentIndex);
    }
    public void NextLevel()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(nextIndex);
    }
    public void ReturnToMain()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(0);
    }
}
