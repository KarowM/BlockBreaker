using UnityEngine;

public class Level : MonoBehaviour {

    [SerializeField] int numBlocks;

    SceneLoader sceneLoader;

    private void Start() {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void addBlock() {
        numBlocks++;
    }

    public void removeBlock() {
        numBlocks--;
        if (numBlocks == 0) {
            sceneLoader.LoadNextScene();
        }
    }
}
