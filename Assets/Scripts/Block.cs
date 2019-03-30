using UnityEngine;

public class Block : MonoBehaviour {

    [SerializeField] AudioClip breakSound;

    Level level;

    private void Start() {
        level = FindObjectOfType<Level>();
        level.addBlock();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position, 1);
        level.removeBlock();
        Destroy(gameObject);
    }

}
