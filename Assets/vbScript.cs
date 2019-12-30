using System.Collections;
using System.Collections.Generic;
using Vuforia;
using UnityEngine;

public class vbScript : MonoBehaviour,IVirtualButtonEventHandler
{
    private GameObject vbButtonObject;
  


    // Start is called before the first frame update
    void Start()
    {
        vbButtonObject = GameObject.Find("vb1");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("******************************************************");
     
       // throw new System.NotImplementedException();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
       
        Debug.Log("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
       // throw new System.NotImplementedException();
    }

}
