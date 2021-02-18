using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class frames : MonoBehaviour
{

    public GameObject TextBox;

    int frame = 1;
    // Start is called before the first frame update
    void Start()
    {
      //disable vsync 
      QualitySettings.vSyncCount = 0; 
      //caps framerate at 60
      Application.targetFrameRate = 60;  
      
    }

    // Update is called once per frame
    void Update()
    {
       TextBox.GetComponent<TextMeshProUGUI>().SetText(frame.ToString());  
       frame ++;
    }
}
