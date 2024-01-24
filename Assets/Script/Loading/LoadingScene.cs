using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    public Slider slider;
    public Text ProgressIndicator;
    public string SceneName;
    public float speed;
    public Text Starttext;
    public Text LoadingText;
    public Text Percentage1;
    public Text Percentage2;

    private float time;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Awake()
    {
        
    }

    /*
    IEnumerator LoadingSceneCoroutine()
    {
       AsyncOperation operation = SceneManager.LoadSceneAsync(SceneName);
        operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            time = +Time.time;
      //      slider.value = time / 10.0f;

            if(time > 10)
            {
           //     FadeTextToFull();
                Destroy(LoadingText.gameObject);
                Destroy(slider.gameObject);

                GameObject.Find("Canvas").transform.Find("StartButton").gameObject.SetActive(true);

            }

            yield return null;
        }
    }
    */

    // Update is called once per frame
    void Update()
    {
        if(slider.value < 100)
        {
            slider.value += Time.deltaTime * speed;
            ProgressIndicator.text = slider.value.ToString("F0");
        }
        else
        {
            Destroy(LoadingText.gameObject);
            Destroy(slider.gameObject);
            Destroy(Percentage1.gameObject);
            Destroy(Percentage2.gameObject);
            GameObject.Find("Canvas").transform.Find("StartButton").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("Title").gameObject.SetActive(true);
        }

    }
}
