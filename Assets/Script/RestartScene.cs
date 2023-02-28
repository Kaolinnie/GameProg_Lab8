using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (!other.gameObject.transform.CompareTag("Player")) return;
        SceneManager.LoadScene("SampleScene");
    }
}
