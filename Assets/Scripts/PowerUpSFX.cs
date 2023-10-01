using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bogay.SceneAudioManager;
using UnityEngine.UI;

public class PowerUpSFX : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            SceneAudioManager.instance.PlayByName("power-up");
        });
    }
}
