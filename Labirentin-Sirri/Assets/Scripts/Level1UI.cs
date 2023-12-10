using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
public class Level1UI : MonoBehaviour
{
    
    [Header("UI Pages")]
    public GameObject levelMenu;
    public GameObject selectLevel;
    public GameObject completeLevel;

    [Header("Main Menu Buttons")]
    public Button nextButton;
    public Button restartButton;
    public Button mainMenuButton;
    public Button selectLevelButton;
    public Button tekrarButton;
    [Header("Level Buttons")]
    public Button Level1Button;
    public Button Level2Button;
    public Button Level3Button;
    public Button Level4Button;
    public Button Level5Button;
    [Header("Socket Interactors")]
    public GameObject object1;
    public GameObject socket1;
    public GameObject object2;
    public GameObject socket2;
    public GameObject object3;
    public GameObject socket3;
    public GameObject object4;
    public GameObject socket4;
    public Transform playerPosition;
    [Header("Next Level Index")]
    public int nextIndex;

    public List<Button> returnButtons;
    private bool check = false;
    Transform starterPosition;
    private void Awake()
    {
        starterPosition = playerPosition;
    }
    void Start()
    {
        EnableLevelMenu();
        
        nextButton.onClick.AddListener(NextLevel);
        restartButton.onClick.AddListener(RestartLevel);
        mainMenuButton.onClick.AddListener(ReturnToMain);
        selectLevelButton.onClick.AddListener(SelectLevels);
        Level1Button.onClick.AddListener(ChangeLevelto1);
        Level2Button.onClick.AddListener(ChangeLevelto2);
        Level3Button.onClick.AddListener(ChangeLevelto3);
        Level4Button.onClick.AddListener(ChangeLevelto4);
        Level5Button.onClick.AddListener(ChangeLevelto5);
        tekrarButton.onClick.AddListener(RestartLevel);
        foreach (var item in returnButtons)
        {
            item.onClick.AddListener(EnableLevelMenu);
            check = false;
        }


    }
    void Update()
    {

        if (object1.transform.position == socket1.transform.position && object2.transform.position == socket2.transform.position
            && object3.transform.position == socket3.transform.position && object4.transform.position == socket4.transform.position)
        {
            if(check == false)
            {
                EnableLevelMenu();
                completeLevel.SetActive(true);
            }
            
        }
        else
        {
            //HideAll();
            check = false;
            completeLevel.SetActive(false);
        }

    }
    public void HideAll()
    {
        levelMenu.SetActive(false);
        selectLevel.SetActive(false);
        check = false;
    }

    public void EnableLevelMenu()
    {
        levelMenu.SetActive(true);
        selectLevel.SetActive(false);
        check = true;
        
    }
    public void SelectLevels()
    {
        levelMenu.SetActive(false);
        selectLevel.SetActive(true);
    }
    public void RestartLevel()
    {
        HideAll();
        Application.LoadLevel(Application.loadedLevel);
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
