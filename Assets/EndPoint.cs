using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndPoint : MonoBehaviour
{
    public Image whiteScreen; 
    public TextMeshProUGUI gameCompleteText; 
    public float fadeDuration = 1f; 
    public float delayAfterEffect = 0.5f; 

    private void Start()
    {
        if (whiteScreen != null)
        {
            Color color = whiteScreen.color;
            color.a = 0; 
            whiteScreen.color = color;
        }

        if (gameCompleteText != null)
        {
            gameCompleteText.gameObject.SetActive(false); 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            StartCoroutine(PlayWhiteScreenEffect());
            PlayerPrefs.DeleteAll();
        }
    }

    private IEnumerator PlayWhiteScreenEffect()
    {
        float timer = 0f;
        Color color = whiteScreen.color;

        
        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            color.a = Mathf.Lerp(0, 1, timer / fadeDuration);
            whiteScreen.color = color;
            yield return null;
        }

       
        color.a = 1;
        whiteScreen.color = color;

       
        yield return new WaitForSeconds(delayAfterEffect);

        
        if (gameCompleteText != null)
        {
            gameCompleteText.gameObject.SetActive(true);
            gameCompleteText.text = "Game Complete"; 
        }

    }
}

