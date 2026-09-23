using UnityEngine;

public class MovSeletor : MonoBehaviour
{
    public enum Andar
    {
        lugar1,
		lugar2,
        lugar3,
		lugar4,
	}
    [SerializeField] private Andar andarAtual;
}
