using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticles; // Reference to the particle system for dust

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the object collides with the ground
        if (collision.gameObject.tag == "Ground")
        {
            // Play the dust particle system
            dustParticles.Play();
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        // Stop the dust particle system when the object stops colliding with the ground
        if (collision.gameObject.tag == "Ground")
        {
            dustParticles.Stop();
        }
    }
}

