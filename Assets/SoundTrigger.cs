using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        AudioSource.PlayClipAtPoint(GetComponent<AudioSource>().clip, gameObject.transform.position);
    }
}