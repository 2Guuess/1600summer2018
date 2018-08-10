using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUi : MonoBehaviour
{
    public InData CoinCollection;
    public Text CoinText;

    private void Update()
    {
        CoinText.text = CoinCollection.Value.ToString();
    }
}
