using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneTransition : MonoBehaviour
{
    public Image fadeImage; 
    public float fadeDuration = 1f;  

    private void Start()
    {
        StartCoroutine(FadeIn());
    }

    public void ReloadScene()
    {
        StartCoroutine(FadeOutAndReload());
    }

    private IEnumerator FadeIn()
    {
        float timer = 0f;
        Color color = fadeImage.color;

        
        color.a = 1f;
        fadeImage.color = color;

       
        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            
            color.a = Mathf.Lerp(1f, 0f, timer / fadeDuration);
            fadeImage.color = color;
            yield return null;
        }

        
        color.a = 0f;
        fadeImage.color = color;
    }


    private IEnumerator FadeOutAndReload()
    {
        float timer = 0f;
        Color color = fadeImage.color;

        
        color.a = 0f;
        fadeImage.color = color;

       
        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            color.a = Mathf.Clamp01(timer / fadeDuration);
            fadeImage.color = color;
            yield return null;
        }

        
        color.a = 1f;
        fadeImage.color = color;

        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        
        yield return new WaitForEndOfFrame();
    }

}
