using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(
            () =>
            {
                Camera.main.gameObject.transform.Translate((float)235.559402, (float)129.357697, -10);
            }
        );
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
