using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{

    public Text StartText;
    public Button Lobi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void OnClick()
    {
        SceneManager.LoadScene("Lobi");
    }

    private void Awake()
    {
        StartText = GetComponent<Text>();
        StartCoroutine(FadeTextToFull());
    }

    public IEnumerator FadeTextToFull()
    {
        StartText.color = new Color(StartText.color.r, StartText.color.g, StartText.color.b, 0);
        while (StartText.color.a < 1.0f)
        {
            StartText.color = new Color(StartText.color.r, StartText.color.g, StartText.color.b, StartText.color.a + (Time.deltaTime / 2.0f));
            yield return null;
        }

        StartCoroutine(FadeTextToZero());
    }

    public IEnumerator FadeTextToZero()
    {
        StartText.color = new Color(StartText.color.r, StartText.color.g, StartText.color.b, 1);
        while (StartText.color.a > 0.0f)
        {
            StartText.color = new Color(StartText.color.r, StartText.color.g, StartText.color.b, StartText.color.a - (Time.deltaTime / 2.0f));
            yield return null;
        }

        StartCoroutine(FadeTextToFull());
    }
}
