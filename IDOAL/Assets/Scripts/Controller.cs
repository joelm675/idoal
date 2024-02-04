using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    public Data data;

    [SerializeField] private TMP_Text currencyText;

    private void Start()
    {
        data = new Data();
    }
    private void Update()
    {
        currencyText.text = data.currency + " CURRENCY";
    }

    public void GenerateCurrency()
    {
        data.currency += 1;
    }
}
