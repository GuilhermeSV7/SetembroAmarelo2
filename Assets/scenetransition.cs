using System.Collections;
using UnityEngine;

public class scenetransition : MonoBehaviour
{
    [SerializeField] GameObject sceneenter;
    [SerializeField] GameObject sceneleave;
    void Start()
    {
        sceneenter.SetActive(true);
        StartCoroutine(TurnOffTransition());
    }

    IEnumerator TurnOffTransition()
    {
        yield return new WaitForSeconds(3);
        sceneenter.SetActive(false);
        sceneleave.SetActive(true);
        yield return new WaitForSeconds(3);
        sceneleave.SetActive(false);
    }
}
