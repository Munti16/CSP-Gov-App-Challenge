using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class donation : MonoBehaviour
{
    [SerializeField] int donated;
    [SerializeField] TextMeshProUGUI text;
    void Update()
    {
        text.text = donated.ToString();
    }

    public void donate()
    {
        donated += 10;
    }
}
