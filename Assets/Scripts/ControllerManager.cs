using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerManager : MonoBehaviour
{
    public Text inputText;

    void Update()
    {
        inputText.text  = "Trigger:   " + OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger).ToString()
                        + "\nTouchpad Button:   " + OVRInput.Get(OVRInput.Button.PrimaryTouchpad).ToString()
                        + "\nTouchpad Touch:   " + OVRInput.Get(OVRInput.Touch.PrimaryTouchpad).ToString()
                        + "\nTouchpad Axis2D:   " + OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad).ToString()
                        + "\nDpadUp:   " + OVRInput.Get(OVRInput.Button.DpadUp).ToString()
                        + "\nDpadDown:   " + OVRInput.Get(OVRInput.Button.DpadDown).ToString()
                        + "\nDpadLeft:   " + OVRInput.Get(OVRInput.Button.DpadLeft).ToString()
                        + "\nDpadRight:   " + OVRInput.Get(OVRInput.Button.DpadRight).ToString()
                        + "\nBack:   " + OVRInput.Get(OVRInput.Button.Back).ToString();

    }
}
