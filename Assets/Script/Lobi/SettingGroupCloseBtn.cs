using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingGroupCloseBtn : MonoBehaviour
{
    public GameObject SettingWindowoff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Windowclose()
    {
        SettingWindowoff.gameObject.SetActive(false);
    }
}
