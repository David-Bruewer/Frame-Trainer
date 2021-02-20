using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FrameLoopController : MonoBehaviour
{
    
    public GameObject TextBox;

    public GameObject ColorChange;

    //framerate 
    public int framerate;

    public string inputs;

    public int delay;

    public int color;

    // current frame
    int frame = 1;
    // Start is called before the first frame update
    void Start()
    {
      ColorChange.SetActive(false);
      //disable vsync 
      QualitySettings.vSyncCount = 0; 
      //caps framerate at framerate
      Application.targetFrameRate = framerate;  
      
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.anyKeyDown){
        inputs += (frame - delay).ToString() + " "+ Input.inputString;
        TextBox.GetComponent<TextMeshProUGUI>().SetText(inputs);
        inputs += ", "; 
      } 

      if(frame == color)
      {
        ColorChange.SetActive(true);
      }
       frame ++;

    }
}
