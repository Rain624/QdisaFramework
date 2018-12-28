﻿/****************************************************************************
 *
 * Copyright (c) 2018 Rain
 *
 ****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Qdisa.Net;


public class ServerExample : MonoBehaviour {
    public static NetParam netParam = new NetParam("192.168.21.20", 8090, NetParam.NetProtocol.TCP);
    Server server = new Server(netParam);
   
    // Use this for initialization
    void Start () {
        //必有
        server.StartServer();
        //server.OnReceive += (string s) => { Debug.Log(s); };
        server.OnReceive += DebugTest;
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            server.SendMessage("1");
        }
       

    }

    /// <summary>
    /// 必有
    /// </summary>
    private void OnDestroy()
    {
        server.OnDestroy();
    }
    private void DebugTest(string s)
    {
        Debug.Log(s);
        transform.position = Vector3.up;
    }
}


