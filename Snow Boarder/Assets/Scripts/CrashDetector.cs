using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem crashEffect;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("ReloadScene", loadDelay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
