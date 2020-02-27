using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    // Start is called before the first frame update
    public int piece;
    void Start()
    {
        piece = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnGUI()
    {
        GUI.Label(new Rect(40, 40, 100, 100), "Nombre de points : " + piece);
    }

}
