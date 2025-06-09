using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI txtHealth;

    // Start is called before the first frame update
    void Start()
    {
        txtMoney.text = "$0";
    }

    public void UpdateMoneytext(string moneyAmount)
    {
        txtMoney.text = "$" + moneyAmount;
    }

    public void UpdateHealthText(string healthPoints)
    {
        txtHealth.text = "HP" + healthPoints;
    }
}
