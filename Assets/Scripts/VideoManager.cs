using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;

public class VideoManager : MonoBehaviour 
{
    [SerializeField] TextMeshProUGUI TVUrlTextField;
    [SerializeField] VideoPlayer videoPlayer;

    public void CallURL()
    {
        videoPlayer.url = TVUrlTextField.text;
        //videoPlayer.Play();
    }

    /*public void Stepforward()
    {
        videoPlayer.StepForward();
    }*/
}
