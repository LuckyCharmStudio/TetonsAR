using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UI_Toggle : MonoBehaviour {

    public GameObject Panel;

    public void showDetails()
    {
        Panel.gameObject.SetActive(true);
    }
}
