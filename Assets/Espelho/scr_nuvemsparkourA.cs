using System.Collections;
using UnityEngine;

public class scr_nuvemsparkourA : MonoBehaviour
{
    [SerializeField] int espelholvl;
    [SerializeField] int direction = 1;
    [SerializeField] bool levelativo;
    void Update() 
    {
        if (scr_espelhostatic.espelholevel == espelholvl && !levelativo) 
        {
            levelativo = true;
            StartCoroutine(PlatformMovement());
        }
    }

    IEnumerator PlatformMovement() 
    {
        for (int i = 0; i < 25; i++) {
            yield return new WaitForSeconds(0.06f);
            transform.position = transform.position + new Vector3(0, 0.1f * direction);
        }
        for (int i = 0; i < 25; i++)
        {
            yield return new WaitForSeconds(0.06f);
            transform.position = transform.position + new Vector3(0, -0.1f * direction);
        }
        if (scr_espelhostatic.espelholevel == espelholvl)
        {
            StartCoroutine(PlatformMovement());
        }
        else { levelativo = false;}
        yield return null;
    }

}
