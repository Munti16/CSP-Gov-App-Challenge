using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class menuOpener : MonoBehaviour
{
    [SerializeField] private List<GameObject> allMenus = new List<GameObject>();
    
    public void OpenMenu(GameObject targetMenu)
    {
        foreach (GameObject menu in allMenus)
        {
            if (menu != targetMenu)
            {
                menu.SetActive(false);
            }
        }
        targetMenu.SetActive(true);
    }
}
