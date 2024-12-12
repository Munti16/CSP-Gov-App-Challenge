using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "accounts", menuName = "Data")]
public class accountData : ScriptableObject
{
    public string accountUsername;
    public string accountPassword;
    public bool isPearReviewer;
}
