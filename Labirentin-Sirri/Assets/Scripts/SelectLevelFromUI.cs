using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class SelectLevelFromUI : MonoBehaviour
{
    public TMPro.TMP_Dropdown turnDropdown;
    public int selectScene;
    public Button levelButton;
    private void Start()
    {
        levelButton.onClick.AddListener(StartLevel1);

    }
  
    public void StartLevel1()
    {
        SceneTransitionManager.singleton.GoToSceneAsync(selectScene);

    }
}