using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_buttons : MonoBehaviour {

    public void GoToMainMenu()
    {
        Application.LoadLevel("main_menu");
    }

    public void GoToARCamera()
    {
        Application.LoadLevel("ARcamera");
    }

    public void GoToFound()
    {
        Application.LoadLevel("found");
    }

    public void GoToArena()
    {
        Application.LoadLevel("arena");
    }

    public void GoToMarket()
    {
        Application.LoadLevel("market");
    }

    public void GoToFossils()
    {
        Application.LoadLevel("fossils");
    }

    public void GoToLab()
    {
        Application.LoadLevel("lab");
    }

    public void GoToSettings()
    {
        Application.LoadLevel("settings");
    }

    public void ExitApplication()
    {
        Application.Quit();
    }
}
