using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject CraftMenu;
    public GameObject UIMenuGame;

    public GameObject SettingsMenu;

    public GameObject OnlineRoomFindingMenu;

    public GameObject MainMenu;

    public GameObject ToMainMenu;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void CraftButton()
    {
        //кнопка крафта
        CraftMenu.SetActive(!CraftMenu.activeInHierarchy);
        UIMenuGame.SetActive(!UIMenuGame.activeInHierarchy);
    }

    public void PlayButton()
    {
        //кнопка поиска игры, онлайн комнаты 
        OnlineRoomFindingMenu.SetActive(true);
        ToMainMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void SettingsButton()
    {
        //кнопка настроек
        SettingsMenu.SetActive(true);
        ToMainMenu.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void ExitButton()
    {
        //кнопка выхода из игры
        Application.Quit();
    }

    public void ToMainMenuButton()
    {
        //кнопка для выхода на главное меню (из любой минюшки)
        SettingsMenu.SetActive(false);
        OnlineRoomFindingMenu.SetActive(false);
        ToMainMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
}
