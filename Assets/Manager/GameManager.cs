using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Qdisa;

[QMonoSingletonPath("[Game]/GameManager")]
public class GameManager : MonoBehaviour,ISingleton {

    private UIManager uiManager;
    private AudioManager audioManager;
    private PlayerManager playerManager;
    private CameraManager cameraManager;
    private JsonManager jsonManager;

    private ExampleManager exampleManager;

    private GameManager()
    {

    }

    public static GameManager Instance
    {
        get
        {
            return MonoSingletonProperty<GameManager>.Instance;      
        }
    }
    public  void Dispose()
    {
        MonoSingletonProperty<GameManager>.Dispose();
    }
    private void Awake()
    {
        InitManager();
      
    }
	private void Update(){
		UpdateManager ();
	}
    private void InitManager()
    {
        uiManager = new UIManager(this);
        audioManager = new AudioManager(this);
        playerManager = new PlayerManager(this);
        cameraManager = new CameraManager(this);
        jsonManager = new JsonManager(this);

        exampleManager = new ExampleManager(this);

        uiManager.OnInit();
        audioManager.OnInit();
        playerManager.OnInit();
        cameraManager.OnInit();
        jsonManager.OnInit();

    }
    private void DestroyManager()
    {
        uiManager.OnDestroy();
        audioManager.OnDestroy();
        playerManager.OnDestroy();
        cameraManager.OnDestroy();
        jsonManager.OnDestroy();
    }

    private void UpdateManager()
    {
        uiManager.OnUpdate();
        audioManager.OnUpdate();
        playerManager.OnUpdate();
        cameraManager.OnUpdate();
        jsonManager.OnUpdate();
    }
 
    void Destroy()
    {
        DestroyManager();
        Dispose();
    }
   public  void Example()
    {
        Debug.Log("gamemanager已经执行了example方法"); 
    }
    public void ExampleManagerTest()
    {
        exampleManager.ExampleMethod();
    }
}
