using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FrameLoopController : MonoBehaviour
{
    
    public GameObject TextBox;

    //framerate 
    public int FrameRate;

    public string inputs;

    // current frame
    int frame = 1;
    // Start is called before the first frame update
    void Start()
    {
      //disable vsync 
      QualitySettings.vSyncCount = 0; 
      //caps framerate at framerate
      Application.targetFrameRate = FrameRate;  
      
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.anyKeyDown){
        inputs += frame.ToString() + " "+ Input.inputString;
        TextBox.GetComponent<TextMeshProUGUI>().SetText(inputs);
        inputs += ", "; 
      } 
       frame ++;

    }
}
