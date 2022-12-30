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
        //������ ������
        CraftMenu.SetActive(!CraftMenu.activeInHierarchy);
        UIMenuGame.SetActive(!UIMenuGame.activeInHierarchy);
    }

    public void PlayButton()
    {
        //������ ������ ����, ������ ������� 
        OnlineRoomFindingMenu.SetActive(true);
        ToMainMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void SettingsButton()
    {
        //������ ��������
        SettingsMenu.SetActive(true);
        ToMainMenu.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void ExitButton()
    {
        //������ ������ �� ����
        Application.Quit();
    }

    public void ToMainMenuButton()
    {
        //������ ��� ������ �� ������� ���� (�� ����� �������)
        SettingsMenu.SetActive(false);
        OnlineRoomFindingMenu.SetActive(false);
        ToMainMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
}
