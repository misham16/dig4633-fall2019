using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour
{
        public float fadeDurationSeconds;
    
        CanvasGroup canvasGroup;
 
    private void Awake() {
        canvasGroup = GetComponent<CanvasGroup>();
    }
        public void FadeOut() {
        StartCoroutine(fadeCoroutine(0));
    }
 
    public void FadeIn() {
        if()
        {
            StartCoroutine(fadeCoroutine(1));
        }
       
    }
 
    private IEnumerator fadeCoroutine(float endingAlpha) {
        float elapsedTime = 0;
        float startingAlpha = canvasGroup.alpha;
 
        while(elapsedTime <= fadeDurationSeconds) {
            elapsedTime += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(startingAlpha, endingAlpha, elapsedTime / fadeDurationSeconds);
            yield return null;
        }
    }
}
}
