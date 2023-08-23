using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class PlayVideoInWebGL : MonoBehaviour
{
   [SerializeField] string videoFileName;

    public void Playvideo()
    {
   
        VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
      
        if (videoPlayer)
        {
            string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath,videoFileName);
            Debug.Log(videoPath);
            videoPlayer.url = videoPath;
            videoPlayer.Play();

        }
    }
}
