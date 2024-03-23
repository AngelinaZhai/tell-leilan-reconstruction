using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleCategory : MonoBehaviour
{

    public Toggle toggle;
    public GameObject targetObject;
    // Start is called before the first frame update
    void Start()
    {
        toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(toggle);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleValueChanged(bool val){
        if(val == true){
            // targetObject.enabled = true;
            if (toggle.isOn){
                targetObject.SetActive(true);
            }
            else {
                targetObject.SetActive(false);
            }
        }
    }
}
