using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text timerText;
    public bool goal;
    public GameObject retryButton;

    GameObject[] objects;
    float time = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        timerText = timerText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (goal == false)
        {
            time += Time.deltaTime;
        }

        objects = GameObject.FindGameObjectsWithTag("Obj");

        if (objects.Length == 0)
        {
            goal = true;
            retryButton.SetActive(true);
        }

        int currentTime = Mathf.FloorToInt(time);
        timerText.text = "Time: " + currentTime.ToString();
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}