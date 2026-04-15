using UnityEngine;
using TMPro;
using System.Collections;

public class GoalTextFade : MonoBehaviour
{
    public TextMeshProUGUI goalText;
    public float showTime = 2f;
    public float fadeTime = 2f;

    private void Awake()
    {
        if (goalText != null)
        {
            Color c = goalText.color;
            c.a = 0f;
            goalText.color = c;
        }
    }

    public void ShowText()
    {
        StopAllCoroutines();
        StartCoroutine(FadeSequence());
    }

    private IEnumerator FadeSequence()
    {
        if (goalText == null) yield break;

        gameObject.SetActive(true);

        Color c = goalText.color;
        c.a = 1f;
        goalText.color = c;

        yield return new WaitForSeconds(showTime);

        float timer = 0f;
        while (timer < fadeTime)
        {
            timer += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, timer / fadeTime);

            c = goalText.color;
            c.a = alpha;
            goalText.color = c;

            yield return null;
        }

        c = goalText.color;
        c.a = 0f;
        goalText.color = c;
    }
}