using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFader : MonoBehaviour
{
    public Image fadeImage;
    void Start()
    {
        if (fadeImage != null)
        {
            fadeImage.canvasRenderer.SetAlpha(0f);
        }
    }

    public void FadeIn(float time)
    {
        fadeImage.CrossFadeAlpha(1, time, false);
    }
    public void FadeOut(float time)
    {
        Debug.Log("FadeOut");
        fadeImage.CrossFadeAlpha(0, time, false);
    }

}
