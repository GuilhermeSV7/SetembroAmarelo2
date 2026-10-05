using System.Collections;
using UnityEngine;

public class scenetransition : MonoBehaviour
{
    [SerializeField] GameObject sceneenter;
    void Start()
    {
        sceneenter.SetActive(true);
        StartCoroutine(TurnOffTransition());
    }

    IEnumerator TurnOffTransition()
    {
        yield return new WaitForSeconds(2.5f);
        sceneenter.SetActive(false);
    }
}
