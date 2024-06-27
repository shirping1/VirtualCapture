using Cinemachine.PostFX;
using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class CloseEyes : MonoBehaviour
{
    public CinemachineVolumeSettings volumeSettings;
    public VolumeProfile volumeProfile;
    public float vignetteintensity;
    Vignette vignette;
    public float bogan;

    public void Start()
    {
        volumeSettings = GetComponent<CinemachineVolumeSettings>();
        volumeProfile.TryGet(out vignette);
        //vignetteintensity = vignette.intensity.value;
        vignette.intensity.value = 0f;
    }

    public void Update()
    {
        vignette.intensity.value = bogan;
    }

    public void startCloseEyes()
    {
        StartCoroutine(closeEyes());
    }

    public IEnumerator closeEyes()
    {
        float time = 0;
        while (time <= 3.3f)
        {
            time += Time.deltaTime;
            float t = time / 3.3f;

            bogan = Mathf.Lerp(0, 1f, t);
            yield return null;
        }
    }


    

}
