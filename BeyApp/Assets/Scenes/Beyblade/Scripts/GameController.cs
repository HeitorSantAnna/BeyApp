using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameController : MonoBehaviour
{
    [SerializeField] UIDocument uIDocument;

    [SerializeField] Button edit, create, view, exit;

    void Start()
    {
        edit = uIDocument.rootVisualElement.Q<Button>("Edit");

        create = uIDocument.rootVisualElement.Q<Button>("Create");

        view = uIDocument.rootVisualElement.Q<Button>("View");

        exit = uIDocument.rootVisualElement.Q<Button>("Exit");

        edit.clicked += Editer;

        create.clicked += Creator;

        view.clicked += Viwer;

        exit.clicked += Exit;
    }

    void Editer()
    {
        //SceneManager.LoadScene("");
        Debug.Log("O botão Editer foi apertado");
    }

    void Creator()
    {
        //SceneManager.LoadScene("");
        Debug.Log("O botão Creator foi apertado");
    }

    void Viwer()
    {
        //SceneManager.LoadScene("");
        Debug.Log("O botão Viwer foi apertado");
    }

    void Exit()
    {
        Application.Quit();
    }
}
