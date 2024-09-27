using UnityEngine;
using System.Collections;
using TMPro;  // Import TextMeshPro namespace

public class TextFade : MonoBehaviour {
    public TextMeshProUGUI tmpText;
    public float fadeDuration = 1f;

    public void FadeIn() {
        StartCoroutine(FadeTextToFullAlpha());
    }

    public void FadeOut() {
        StartCoroutine(FadeTextToZeroAlpha());
    }

    private IEnumerator FadeTextToFullAlpha() {
        float alpha = 0f;
        Color color = tmpText.color;
        while (alpha < 1f) {
            alpha += Time.deltaTime / fadeDuration;
            tmpText.color = new Color(color.r, color.g, color.b, alpha); // Modify alpha
            yield return null;
        }
    }

    private IEnumerator FadeTextToZeroAlpha() {
        float alpha = 1f;
        Color color = tmpText.color;
        while (alpha > 0f) {
            alpha -= Time.deltaTime / fadeDuration;
            tmpText.color = new Color(color.r, color.g, color.b, alpha); // Modify alpha
            yield return null;
        }
    }
}