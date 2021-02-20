using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Manager : MonoBehaviour
{


    //Sets Framerate
    public GameObject FrameRateSetter;
    public int framerate;

    //Sets number of inputs 
    public GameObject DelaySetter;
    public int delay;

    public GameObject ColorChange;
    public int color;

    //FrameLoop Prefab 
    public GameObject loop;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //updates framerate
        string frs = FrameRateSetter.GetComponent<TMP_InputField>().text;
        int.TryParse(frs, out framerate);

        //updates # of inputs 
        string ips = DelaySetter.GetComponent<TMP_InputField>().text;
        int.TryParse(ips, out delay);

        string cs = ColorChange.GetComponent<TMP_InputField>().text;
        int.TryParse(cs, out color);

    }
}
