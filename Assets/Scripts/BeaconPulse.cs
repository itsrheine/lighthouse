using UnityEngine;

public class BeaconPulse : MonoBehaviour
{
    public Light beaconLight;
    public float minIntensity = 1.5f;
    public float maxIntensity = 5f;
    public float speed = 2f;

    void Update()
    {
        if (beaconLight != null)
        {
            beaconLight.intensity = Mathf.Lerp(minIntensity, maxIntensity, (Mathf.Sin(Time.time * speed) + 1f) / 2f);
        }
    }
}