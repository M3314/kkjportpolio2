using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextFadeinFadeout : MonoBehaviour
{
    private CanvasGroup cg;
    public float fadeTime = 2.0f;
    float accumTime = 0.0f;
    private Coroutine fadeCor;
    public string SceneName;

    private void Awake()
    {
        cg = gameObject.GetComponent<CanvasGroup>();
        StartFadeIn();
    }

    public void StartFadeIn()
    {
        if (fadeCor != null)
        {
            StopAllCoroutines();
            fadeCor = null;
        }
       fadeCor = StartCoroutine(FadeIn());
    }

    private IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(0.2f);
        accumTime = 0.0f;
        while (accumTime < fadeTime)
        {
            cg.alpha = Mathf.Lerp(0.0f, 1.0f, accumTime / fadeTime);
            yield return 0;
            accumTime += Time.deltaTime;
        }
        cg.alpha = 1.0f;
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneName);
        operation.allowSceneActivation = true;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}