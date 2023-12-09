using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    private void OnMouseDown() {
        GameManager.clicks++;
    }
}
