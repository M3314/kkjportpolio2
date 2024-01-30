using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingText : MonoBehaviour
{
    public Text Loadingtext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        Loadingtext = GetComponent<Text>();
        StartCoroutine(FadeTextToFull());
    }

    public IEnumerator FadeTextToFull()
    {
        Loadingtext.color = new Color(Loadingtext.color.r, Loadingtext.color.g, Loadingtext.color.b, 0);
        while (Loadingtext.color.a < 1.5f)
        {
            Loadingtext.color = new Color(Loadingtext.color.r, Loadingtext.color.g, Loadingtext.color.b, Loadingtext.color.a + (Time.deltaTime / 2.0f));
            yield return null;
        }

        StartCoroutine(FadeTextToZero());
    }

    public IEnumerator FadeTextToZero()
    {
        Loadingtext.color = new Color(Loadingtext.color.r, Loadingtext.color.g, Loadingtext.color.b, 1);
        while (Loadingtext.color.a > 0.0f)
        {
            Loadingtext.color = new Color(Loadingtext.color.r, Loadingtext.color.g, Loadingtext.color.b, Loadingtext.color.a - (Time.deltaTime / 2.0f));
            yield return null;
        }

        StartCoroutine(FadeTextToFull());
    }
}
