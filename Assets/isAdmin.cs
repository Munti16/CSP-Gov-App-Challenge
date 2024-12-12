using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class isAdmin : MonoBehaviour
{
    [SerializeField] GameObject accountControler;
    [SerializeField] TextMeshProUGUI text;
    void Update()
    {
        if (accountControler.GetComponent<AccountControler>().getCurrentAccount() != null)
        {
            if(accountControler.GetComponent<AccountControler>().getCurrentAccount().isPearReviewer)
            {
                text.fontStyle = FontStyles.Normal;
            }
        }
    }
}
