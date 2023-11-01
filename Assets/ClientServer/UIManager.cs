using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject startMenu;
    public InputField usernameField;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    public void ConnectToServer()
    {
        Client.instance.ConnectToServer();
    }

    public void DisconnectFromServer()
    {
        Client.instance.DisconnectFromServer();
    }

    public void SoundSuccess()
    {
        Client.instance.SoundSend("Success");
    }
    public void SoundFail()
    {
        Client.instance.SoundSend("Fail");
    }

    public void XylophoneStart()
    {
        Client.instance.SceneSend("Xylophone");
    }

    public void ResetRobot()
    {
        Client.instance.XyloSend("Reset");
    }

    public void XylophoneC()
    {
        Client.instance.XyloSend("C");
    }

    public void XylophoneD()
    {
        Client.instance.XyloSend("D");
    }

    public void XylophoneE()
    {
        Client.instance.XyloSend("E");
    }
    public void XylophoneF()
    {
        Client.instance.XyloSend("F");
    }
    public void XylophoneG()
    {
        Client.instance.XyloSend("G");
    }
    public void XylophoneA()
    {
        Client.instance.XyloSend("A");
    }
    public void XylophoneB()
    {
        Client.instance.XyloSend("B");
    }

    public void XylophoneC2()
    {
        Client.instance.XyloSend("C2");
    }

    public void XylophoneEntchen()
    {
        Client.instance.XyloSend("Entchen");
    }


    public void LegoStart()
    {
        Client.instance.SceneSend("Lego");
    }

    public void Lego1()
    {
        Client.instance.LegoSend("Lego1");
    }

    public void Lego2()
    {
        Client.instance.LegoSend("Lego2");
    }

    public void Lego3()
    {
        Client.instance.LegoSend("Lego3");
    }

    public void Lego4()
    {
        Client.instance.LegoSend("Lego4");
    }

    public void Lego5()
    {
        Client.instance.LegoSend("Lego5");
    }

    public void Lego6()
    {
        Client.instance.LegoSend("Lego6");
    }

    public void Lego7()
    {
        Client.instance.LegoSend("Lego7");
    }


    public void HandoverStart()
    {
        Client.instance.SceneSend("Handover");
    }

    public void Handover1()
    {
        Client.instance.HandoverSend("Object1");
    }

    public void HandoverRelease1()
    {
        Client.instance.HandoverSend("Release1");
    }

    public void Handover2()
    {
        Client.instance.HandoverSend("Object2");
    }
    public void HandoverRelease2()
    {
        Client.instance.HandoverSend("Release2");
    }

    public void Handover3()
    {
        Client.instance.HandoverSend("Object3");
    }
    public void HandoverRelease3()
    {
        Client.instance.HandoverSend("Release3");
    }

    public void Handover4()
    {
        Client.instance.HandoverSend("Object4");
    }
    public void HandoverRelease4()
    {
        Client.instance.HandoverSend("Release4");
    }

    public void Connect4Start()
    {
        Client.instance.SceneSend("Connect4");
    }
    public void Connect4GetStone()
    {
        Client.instance.Connect4Send("GetStone");
    }
    public void Connect4Row1()
    {
        Client.instance.Connect4Send("1");
    }
    public void Connect4Row2()
    {
        Client.instance.Connect4Send("2");
    }
    public void Connect4Row3()
    {
        Client.instance.Connect4Send("3");
    }
    public void Connect4Row4()
    {
        Client.instance.Connect4Send("4");
    }
    public void Connect4Row5()
    {
        Client.instance.Connect4Send("5");
    }
    public void Connect4Row6()
    {
        Client.instance.Connect4Send("6");
    }
    public void Connect4Row7()
    {
        Client.instance.Connect4Send("7");
    }


    public void Exit()
    {
        startMenu.SetActive(false);
    }


    public void QuitApp()
    {
        Application.Quit();    
    }
}
