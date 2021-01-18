using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class SetVolyme : MonoBehaviour
{
    public AudioMixer mixer;

    public string mixerName;

    public void SetLevel(float slider)
    {
        mixer.SetFloat(mixerName, Mathf.Log10(slider) * 20);
    }
}
