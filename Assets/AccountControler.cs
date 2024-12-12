using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class AccountControler : MonoBehaviour
{
    [SerializeField] private List<accountData> usernames = new List<accountData>();

    [SerializeField] private accountData currentAccount;
    [SerializeField] private accountData adminAccount;
    [SerializeField] private GameObject username;
    [SerializeField] private GameObject password;
    [SerializeField] private menuOpener menuOpener;
    [SerializeField] private GameObject home;

    public void Login()
    {
        if (username.GetComponent<TMP_InputField>().text == "Admin" && password.GetComponent<TMP_InputField>().text == "Admin")
        {
            currentAccount = adminAccount;
            menuOpener.OpenMenu(home);
        }
    }

    public accountData getCurrentAccount()
    {
        return currentAccount;
    }
}
