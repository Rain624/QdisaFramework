/****************************************************************************
 *
 * Copyright (c) 2018 Rain
 * 
 ****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleManager : BaseManager {

	public ExampleManager(GameManager gameManager) : base(gameManager)
    {

    }
    public void ExampleMethod()
    {
        Debug.Log("exampleManager执行了examplemethod");
    }
}
