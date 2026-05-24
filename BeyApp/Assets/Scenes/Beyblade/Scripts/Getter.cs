using UnityEngine;
using UnityEngine.UIElements;

public class Getter : MonoBehaviour
{
    GameObject game;

    UIDocument uIDocument;

    void Awake()
    {
        game = GameObject.Find("DocumentUI");

        uIDocument = game.GetComponent<UIDocument>();

        GameController.uIDocument = uIDocument;
    }

    void Update()
    {
        
    }
}
