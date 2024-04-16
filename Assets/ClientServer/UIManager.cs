using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject startMenu;
    public InputField usernameField;
    public bool waiting = false;

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

    public void DisconnectFromTCPServer()
    {
        Client.instance.DisconnectFromTCPServer();
    }
    #region Sound
    public void SoundSuccess()
    {
        Client.instance.SoundSend("Success");
    }
    public void SoundFail()
    {
        Client.instance.SoundSend("Fail");
    }
    public void Sound(string _sound)
    {
        Client.instance.SoundSend(_sound);
    }

    #endregion

    public void ResetRobot()
    {
        Client.instance.XyloSend("Reset");
    }

    public void ResetLog()
    {
        changeText NotesLog = GameObject.FindObjectOfType(typeof(changeText)) as changeText;
        NotesLog.resetText();
    }


    #region Xylophone
    public void XylophoneStart()
    {
        Client.instance.SceneSend("Xylophone");
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
        //StartCoroutine(XyloSound("02"));
        StartCoroutine(SoundMovement("02", "Entchen", "Xylo"));

    }

    public void XylophoneOpen()
    {
        Client.instance.XyloSend("OpenGripper");
    }

    public void XylophoneClose()
    {
        Client.instance.XyloSend("CloseGripper");
    }
    #endregion
    #region Lego
    public void LegoStart()
    {
        Client.instance.SceneSend("Lego");
    }

    public void Lego1()
    {
        //StartCoroutine(SoundMovement("10", "Lego1", "Lego"));
        Client.instance.LegoSend("Lego1");
    }

    public void Lego2()
    {
        //StartCoroutine(waitforit(2.0f));
        //StartCoroutine(SoundMovement("35", "Lego2", "Lego"));
        Client.instance.LegoSend("Lego2");

    }

    public void Lego3()
    {
        //StartCoroutine(SoundMovement("36", "Lego3", "Lego"));
        Client.instance.LegoSend("Lego3");
    }

    public void Lego4()
    {
        //StartCoroutine(SoundMovement("10", "Lego4", "Lego"));
        Client.instance.LegoSend("Lego4");
    }

    public void Lego5()
    {
        //StartCoroutine(SoundMovement("35", "Lego5", "Lego"));
        Client.instance.LegoSend("Lego5");
    }

    public void Lego6()
    {
        //StartCoroutine(SoundMovement("36", "Lego6", "Lego"));
        Client.instance.LegoSend("Lego6");
    }

    public void Lego7()
    {
        StartCoroutine(SoundMovement("10", "Lego7", "Lego"));
    }

    public void LegoX(string _lego)
    {
        int randomNum = Random.Range(0, 3);
        StartCoroutine(SoundMovementrng(randomNum, _lego, "Lego"));
    }
    #endregion
    #region Handover
    public void HandoverStart()
    {
        Client.instance.SceneSend("Handover");
    }

    public void Handover1()
    {
        StartCoroutine(SoundMovement("15", "Object1", "Hand"));
    }

    public void HandoverRelease1()
    {
        StartCoroutine(SoundMovement("17", "Release1", "Hand"));
    }

    public void Handover2()
    {
        StartCoroutine(SoundMovement("15", "Object2", "Hand"));
    }
    public void HandoverRelease2()
    {
        StartCoroutine(SoundMovement("17", "Release2", "Hand"));

    }

    public void Handover3()
    {
        StartCoroutine(SoundMovement("15", "Object3", "Hand"));

    }
    public void HandoverRelease3()
    {
        StartCoroutine(SoundMovement("17", "Release3", "Hand"));
    }
    public void Handover4()
    {
        StartCoroutine(SoundMovement("15", "Object4", "Hand"));
    }
    public void HandoverRelease4()
    {
        StartCoroutine(SoundMovement("17", "Release4", "Hand"));
    }
    #endregion
    #region Connect4
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
    #endregion

    public void Exit()
    {
        startMenu.SetActive(false);
    }


    public void QuitApp()
    {
        Application.Quit();    
    }


    IEnumerator XyloSound(string _sound, float _time = 2.0f)
    {
        Client.instance.SoundSend(_sound);
        yield return new WaitForSeconds(_time);
        Client.instance.XyloSend("Entchen");
    }

    IEnumerator LegoSound(string _movement, float _time = 2.0f)
    {
        Client.instance.SoundSend("10");
        yield return new WaitForSeconds(_time);
        Client.instance.LegoSend(_movement);
    }

    IEnumerator SoundMovement(string _sound, string _movement, string task, float _time = 2.5f)
    {
        Client.instance.SoundSend(_sound);
        yield return new WaitForSeconds(_time);

        switch (task)
        {
            case "Xylo":
                Client.instance.XyloSend(_movement);
                break;
            case "Lego":
                Client.instance.LegoSend(_movement);
                break;
            case "Hand":
                Client.instance.HandoverSend(_movement);
                break;
            case "Con4":
                Client.instance.Connect4Send(_movement);
                break;
        }

    }

    IEnumerator SoundMovementrng(int randomnr, string _movement, string task, float _time = 2.5f)
    {

        if (randomnr == 0)
        {
            Client.instance.SoundSend("10");
        }
        else if (randomnr == 1)
        {
            Client.instance.SoundSend("35");
        }
        else if (randomnr == 2)
        {
            Client.instance.SoundSend("36");
        }
        else if (randomnr == 3)
        {
            Client.instance.SoundSend("11");
        }


        yield return new WaitForSeconds(_time);

        switch (task)
        {
            case "Xylo":
                Client.instance.XyloSend(_movement);
                break;
            case "Lego":
                Client.instance.LegoSend(_movement);
                break;
            case "Hand":
                Client.instance.HandoverSend(_movement);
                break;
            case "Con4":
                Client.instance.Connect4Send(_movement);
                break;
        }

    }
}
