using UnityEngine;

public class Creditos : MonoBehaviour
{
    public float scrollspeed = 40f;

    private RectTransform rectTransform;

    void Start() 
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        rectTransform.anchoredPosition += new Vector2(0, scrollspeed * Time.deltaTime);
    }

    public void SairCreditos() 
    {
        rectTransform.anchoredPosition = new Vector2(9.081177f, -4849.75f);
    }

    public void SairTitulo()
    {
        rectTransform.anchoredPosition = new Vector2(0f, -43.5f);
    }
}
