using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class TimeSlider : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public VideoPlayer videoPlayer;
    public AudioSource Audio;
    public Slider VolumeTracker;

    Slider TimeStamp;
    bool slider = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        slider = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        float frame = (float)TimeStamp.value * (float)videoPlayer.frameCount;
        videoPlayer.frame = (long)frame;
        slider = false;
    }

    void Start()
    {
        TimeStamp = GetComponent<Slider>();
    }

    
    void Update()
    {
        if (!slider && videoPlayer.isPlaying)
        {
            TimeStamp.value = videoPlayer.frame / (float)videoPlayer.frameCount;
        }
    }

    public void Volume()
    {
        Audio.volume = VolumeTracker.value;
    }

}
