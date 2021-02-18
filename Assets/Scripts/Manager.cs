using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Manager : MonoBehaviour
{


    //Sets Framerate
    public GameObject FrameRateSetter;
    public int Framerate;

    //Sets number of inputs 
    public GameObject InputSetter;
    public int inputs;

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
        int.TryParse(frs, out Framerate);

        //updates # of inputs 
        string ips = InputSetter.GetComponent<TMP_InputField>().text;
        int.TryParse(ips, out inputs);

        if(Input.GetKeyDown(KeyCode.A)){
            Instantiate(loop, new Vector3(0,0,0), Quaternion.identity);
        }
    }
}
