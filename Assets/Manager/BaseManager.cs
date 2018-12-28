using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseManager {
    protected GameManager gameManager;
    public BaseManager(GameManager gameManager)
    {
        this.gameManager = gameManager;
    }
    public virtual void OnInit()
    {

    }
    public virtual void OnDestroy()
    {

    }
    public virtual void OnUpdate()
    {

    }

}
