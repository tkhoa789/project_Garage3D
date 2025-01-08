using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    private float timer = 0f;
    private bool isTiming = false;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject gameManagerGameObject = new GameObject("GameManager");
                    instance = gameManagerGameObject.AddComponent<GameManager>();
                    DontDestroyOnLoad(instance.gameObject);  // Giữ GameManager qua các scene
                }
            }

            return instance;
        }
    }

    private void Update()
    {
        if (isTiming)
        {
            timer += Time.deltaTime;
        }
    }

    public void QuaStart()
    {
        Debug.Log("Start Triggered!");
        isTiming = true;
        timer = 0f;
    }

    public void EndTime()
    {
        Debug.Log("End Triggered!");
        isTiming = false;
    }

    public float GetTimer()
    {
        return timer;
    }

    public bool IsTiming()
    {
        return isTiming;
    }
}
