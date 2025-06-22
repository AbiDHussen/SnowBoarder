using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool isCrashed = true;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground" && isCrashed)
        {
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", loadDelay);
            isCrashed = false; // Prevent multiple triggers
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
