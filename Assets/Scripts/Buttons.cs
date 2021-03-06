﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Buttons : MonoBehaviour
{
    private GameObject loopyboy;
    public Button button;
    public GameObject Text; 
    public GameObject loop;
    public GameObject manager;

    bool canStart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startClicked()
    {
        StartCoroutine(startCounter());
    }


    private IEnumerator startCounter()
    {
        button.interactable = false;
        Destroy(loopyboy);
        Text.GetComponent<TextMeshProUGUI>().SetText("3");
        yield return new WaitForSeconds(1f);
        Text.GetComponent<TextMeshProUGUI>().SetText("2");
        yield return new WaitForSeconds(1f);
        Text.GetComponent<TextMeshProUGUI>().SetText("1");
        yield return new WaitForSeconds(1f);
        Text.GetComponent<TextMeshProUGUI>().SetText("GO!");
        loopyboy = Instantiate(loop, new Vector3(0,0,-20), Quaternion.identity);
        loopyboy.GetComponent<FrameLoopController>().delay = manager.GetComponent<Manager>().delay;
        loopyboy.GetComponent<FrameLoopController>().color = manager.GetComponent<Manager>().color;
        loopyboy.GetComponent<FrameLoopController>().framerate = manager.GetComponent<Manager>().framerate;

        yield return new WaitForSeconds(2f);
        button.interactable = true;
    }
}
