using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientSend : MonoBehaviour
{
    private static void SendTCPData(Packet _packet)
    {
        _packet.WriteLength();
        Client.instance.tcp.SendData(_packet);
    }

    #region Packets
    public static void WelcomeReceived()
    {
        using (Packet _packet = new Packet((int)ClientPackets.welcomeReceived))
        {
            _packet.Write(Client.instance.myId);
            //_packet.Write(UIManager.instance.usernameField.text);

            SendTCPData(_packet);
        }
    }

    public static void SceneSend(string _scene)
    {
        using (Packet _packet = new Packet((int)ClientPackets.sceneSend))
        {
            _packet.Write(Client.instance.myId);
            _packet.Write(_scene);

            SendTCPData(_packet);
        }
    }

    public static void SoundSend(string _scene)
    {
        using (Packet _packet = new Packet((int)ClientPackets.soundSend))
        {
            _packet.Write(Client.instance.myId);
            _packet.Write(_scene);

            SendTCPData(_packet);
        }
    }


    public static void XylomovementSend(string _movement)
    {
        using (Packet _packet = new Packet((int)ClientPackets.xylomovementSend))
        {
            _packet.Write(Client.instance.myId);
            _packet.Write(_movement);

            SendTCPData(_packet);
        }
    }

    public static void LegomovementSend(string _movement)
    {
        using (Packet _packet = new Packet((int)ClientPackets.legomovementSend))
        {
            _packet.Write(Client.instance.myId);
            _packet.Write(_movement);

            SendTCPData(_packet);
        }
    }

    public static void XylomovementReceived(string _movement)
    {
        using (Packet _packet = new Packet((int)ClientPackets.xylomovementReceived))
        {
            _packet.Write(Client.instance.myId);
            _packet.Write($"I received {_movement}");

            SendTCPData(_packet);
        }
    }

    public static void LegomovementReceived(string _movement)
    {
        using (Packet _packet = new Packet((int)ClientPackets.legomovementReceived))
        {
            _packet.Write(Client.instance.myId);
            _packet.Write($"I received {_movement}");

            SendTCPData(_packet);
        }
    }

    public static void RobotmovementSend(float _joint1, float _joint2, float _joint3, float _joint4, float _joint5, float _joint6, float grippervalue)
    {
        using (Packet _packet = new Packet((int)ClientPackets.robotmovementSend))
        {
            _packet.Write(Client.instance.myId);
            _packet.Write(_joint1);
            _packet.Write(_joint2);
            _packet.Write(_joint3);
            _packet.Write(_joint4);
            _packet.Write(_joint5);
            _packet.Write(_joint6);
            _packet.Write(grippervalue);
            SendTCPData(_packet);
        }
    }


        public static void RobotmovementReceived(float _joint1, float _joint2, float _joint3, float _joint4, float _joint5, float _joint6, float grippervalue)
    {
        using (Packet _packet = new Packet((int)ClientPackets.robotmovementReceived))
        {
            _packet.Write(Client.instance.myId);
            _packet.Write($"Joint1 =  {_joint1}");
            _packet.Write($"Joint2 =  {_joint2}");
            _packet.Write($"Joint3 =  {_joint3}");
            _packet.Write($"Joint4 =  {_joint4}");
            _packet.Write($"Joint5 =  {_joint5}");
            _packet.Write($"Joint6 =  {_joint6}");
            _packet.Write($"Joint6 =  {grippervalue}");
            SendTCPData(_packet);
        }
    }

    #endregion
}
