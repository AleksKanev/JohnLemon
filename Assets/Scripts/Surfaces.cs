using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surfaces : MonoBehaviour
{
    [SerializeField]
    public AK.Wwise.Event footstepsEvent;

    [SerializeField]
    private GameObject footstepsGo;

    private void PlayFootstep()
    {
        AkSoundEngine.PostEvent(footstepsEvent.Id, footstepsGo);

    }
}
