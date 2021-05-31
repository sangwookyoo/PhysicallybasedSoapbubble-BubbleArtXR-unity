using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class volume_control : MonoBehaviour
{

    [SerializeField] Volume volume;
    HDRISky sky;
    public Cubemap sky_1, sky_2, sky_3, sky_4, sky_5;
    public Light lit;
    public bool Brotation = true;

    private void Start()
    {
        lit.colorTemperature = 5200f;
        volume.profile.TryGet(out sky);
    }

    private void FixedUpdate()
    {
        if(Brotation == true)
        sky.rotation.value += 0.01f;
    }

    public void change_skybox()
    {
        lit.colorTemperature = 5750f; // Blue Sky Kevin Temp
        sky.hdriSky.value = sky_1;
    }
    public void change_skybox2()
    {
        lit.colorTemperature = 3500f; // Pink Sky Kevin Temp
        sky.hdriSky.value = sky_2;
    }
    public void change_skybox3()
    {
        lit.colorTemperature = 2500f; // Sunset Sky Kevin Temp
        sky.hdriSky.value = sky_3;
    }
    public void change_skybox4()
    {
        lit.colorTemperature = 7500f; // Dry Sky Kevin Temp
        sky.hdriSky.value = sky_4;
    }
    public void change_skybox5()
    {
        lit.colorTemperature = 8000f; // Cold Sky Kevin Temp
        sky.hdriSky.value = sky_5;
    }
}