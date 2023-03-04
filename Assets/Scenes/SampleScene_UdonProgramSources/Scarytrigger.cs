using UnityEngine;
using UdonSharp;
using VRC.SDKBase;

public class Scarytrigger : UdonSharpBehaviour
{
    public AudioSource soundSource;

    private void OnTriggerEnter(Collider other)
    {
        VRCPlayerApi player = other.GetComponent<VRCPlayerApi>();

        if (player != null && player.isLocal)
        {
            soundSource.Play();
        }
    }
}
