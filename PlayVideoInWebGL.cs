using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class PlayVideoInWebGL : MonoBehaviour
{
   [SerializeField] string videoFileName;

    public void Playvideo()
    {
        Debug.Log("01");
        VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
        Debug.Log("02");
        if (videoPlayer)
        {
            string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath,videoFileName);
            Debug.Log(videoPath);
            videoPlayer.url = videoPath;
            videoPlayer.Play();

        }
    }
}