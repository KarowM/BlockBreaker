using UnityEngine;

public class Level : MonoBehaviour {

    [SerializeField] int numBlocks;

    public void addBlock() {
        numBlocks++;
    }

    public void removeBlock() {
        numBlocks--;
    }
}
