using System.Collections;
using UnityEngine;

public class scr_nuvemsparkourB : MonoBehaviour
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
            transform.position = transform.position + new Vector3(0.1f * direction, 0);
        }
        for (int i = 0; i < 25; i++)
        {
            yield return new WaitForSeconds(0.06f);
            transform.position = transform.position + new Vector3(-0.1f * direction, 0);
        }
        if (scr_espelhostatic.espelholevel == espelholvl)
        {
            StartCoroutine(PlatformMovement());
        }
        else { levelativo = false;}
        yield return null;
    }

}
