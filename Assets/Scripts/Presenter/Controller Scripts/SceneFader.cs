using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour {

    public static SceneFader instance;

    [SerializeField]
    private GameObject fadeCanvas;

    [SerializeField]
    private Animator fadeAnim;

	void Awake () {
        MakeSingleton();
	}

    void MakeSingleton()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void FadeIn(string scene)
    {
        StartCoroutine(FadeInAnim(scene));
    }

    public void FadeOut()
    {
        StartCoroutine(FadeOutAnim());
    }

    IEnumerator FadeInAnim(string sceneName)
    {
        fadeCanvas.SetActive(true);
        fadeAnim.Play("FadeIn");
        yield return new WaitForSeconds(.3f);
        SceneManager.LoadScene(sceneName);
        FadeOut();
    }

    IEnumerator FadeOutAnim()
    {
        fadeAnim.Play("FadeOut");
        yield return new WaitForSeconds(.5f);
        fadeCanvas.SetActive(false);
    }
	
}
