using UnityEngine;
using UnityEngine.SceneManagement;  

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float restartDelay = 1f;
    [SerializeField] ParticleSystem crashParticles;
    [SerializeField] AudioSource crashSound;

    PlayerController playerController;

    void Start()
    {
        playerController = FindAnyObjectByType<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");

        if (collision.gameObject.layer == layerIndex)
        {
            playerController.DisableControls();
            crashParticles.Play();
            crashSound.Play();
            Invoke("ReloadScene", restartDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
