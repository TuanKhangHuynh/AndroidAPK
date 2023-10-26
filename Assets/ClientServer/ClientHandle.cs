using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientHandle : MonoBehaviour
{
    /*
    public UserControlls userControlls;
    public RoboControllerAR robotControllsAR;
    */
    public static void Welcome(Packet _packet)
    {
        string _msg = _packet.ReadString();
        int _myId = _packet.ReadInt();

        Debug.Log($"Message from server: {_msg}");
        Client.instance.myId = _myId;
        ClientSend.WelcomeReceived();
    }
    
    /*
    public static void xyloMovement(Packet _packet)
    {
        UserControlls usercontrolls = GameObject.FindObjectOfType(typeof(UserControlls)) as UserControlls;

        string _msg = _packet.ReadString();
        int _myId = _packet.ReadInt();

        ClientSend.XylomovementReceived(_msg);
        switch (_msg)
        {
            case "Start":
                usercontrolls.itemType = UserControlls.ItemType.XylophoneStart;
                usercontrolls.doMovement = true;
                break;
            case "C":
                usercontrolls.itemType = UserControlls.ItemType.XylophoneC;
                usercontrolls.doMovement = true;
                //usercontrolls.movementxylophoneplay("C");
                break;
            case "D":
                usercontrolls.itemType = UserControlls.ItemType.XylophoneD;
                usercontrolls.doMovement = true;
                break;
            case "E":
                usercontrolls.itemType = UserControlls.ItemType.XylophoneE;
                usercontrolls.doMovement = true;
                break;
            case "F":
                usercontrolls.itemType = UserControlls.ItemType.XylophoneF;
                usercontrolls.doMovement = true;
                break;
            case "G":
                usercontrolls.itemType = UserControlls.ItemType.XylophoneG;
                usercontrolls.doMovement = true;
                break;
            case "A":
                usercontrolls.itemType = UserControlls.ItemType.XylophoneA;
                usercontrolls.doMovement = true;
                break;
            case "B":
                usercontrolls.itemType = UserControlls.ItemType.XylophoneB;
                usercontrolls.doMovement = true;
                break;
            case "C2":
                usercontrolls.itemType = UserControlls.ItemType.XylophoneC2;
                usercontrolls.doMovement = true;
                break;
            case "Entchen":
                usercontrolls.entchencounter = 0;
                usercontrolls.entchenmovement = true;
                usercontrolls.itemType = UserControlls.ItemType.Entchen;
                usercontrolls.doMovement = true;
                //usercontrolls.movementxylophoneplayEntchen();
                break;

        }
    }

    public static void legoMovement(Packet _packet)
    {
        UserControlls usercontrolls = GameObject.FindObjectOfType(typeof(UserControlls)) as UserControlls;

        string _msg = _packet.ReadString();
        int _myId = _packet.ReadInt();

        ClientSend.LegomovementReceived(_msg);
        switch (_msg)
        {
            case "Start":
                usercontrolls.itemType = UserControlls.ItemType.LegoStart;
                usercontrolls.doMovement = true;
                break;
            case "Lego1":
                usercontrolls.itemType = UserControlls.ItemType.Lego1;
                usercontrolls.doMovement = true;
                //usercontrolls.movementxylophoneplay("C");
                break;
            case "Lego2":
                usercontrolls.itemType = UserControlls.ItemType.Lego2;
                usercontrolls.doMovement = true;
                break;
            case "Lego3":
                usercontrolls.itemType = UserControlls.ItemType.Lego3;
                usercontrolls.doMovement = true;
                break;
            case "Lego4":
                usercontrolls.itemType = UserControlls.ItemType.Lego4;
                usercontrolls.doMovement = true;
                break;
            case "Lego5":
                usercontrolls.itemType = UserControlls.ItemType.Lego5;
                usercontrolls.doMovement = true;
                break;
            case "Lego6":
                usercontrolls.itemType = UserControlls.ItemType.Lego6;
                usercontrolls.doMovement = true;
                break;
            case "Lego7":
                usercontrolls.itemType = UserControlls.ItemType.Lego7;
                usercontrolls.doMovement = true;
                break;
        }
    }

    public static void robotMovement(Packet _packet)
    {
        RoboControllerAR robotControllsAR = GameObject.FindObjectOfType(typeof(RoboControllerAR)) as RoboControllerAR;

        float _joint1 = _packet.ReadFloat();
        float _joint2 = _packet.ReadFloat();
        float _joint3 = _packet.ReadFloat();
        float _joint4 = _packet.ReadFloat();
        float _joint5 = _packet.ReadFloat();
        float _joint6 = _packet.ReadFloat();
        float _grippervalue = _packet.ReadFloat();
        int _myId = _packet.ReadInt();

        robotControllsAR.setJoints(_joint1, _joint2, _joint3, _joint4, _joint5, _joint6);
        robotControllsAR.set_grippervalue(_grippervalue);
        ClientSend.RobotmovementReceived(_joint1, _joint2, _joint3, _joint4, _joint5, _joint6, _grippervalue);

    }
    */
}
