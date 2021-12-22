using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifes : MonoBehaviour
{
    public static int lifes = 3;

    private void Start()
    {
        lifes = 3;
    }

    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = "Lifes: " + lifes.ToString();
    }
}
