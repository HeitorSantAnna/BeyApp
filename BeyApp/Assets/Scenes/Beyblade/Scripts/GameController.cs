using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameController : MonoBehaviour
{
    public static UIDocument uIDocument;

    [SerializeField] Button edit, create, view, exit;

    void Start()
    {
        if(SceneManager.GetActiveScene().name == "Open")
        {
            edit = uIDocument.rootVisualElement.Q<Button>("Edit");

            create = uIDocument.rootVisualElement.Q<Button>("Create");

            view = uIDocument.rootVisualElement.Q<Button>("View");

            exit = uIDocument.rootVisualElement.Q<Button>("Exit");

            edit.clicked += Editer;

            create.clicked += Creator;

            view.clicked += Viwer;

            exit.clicked += Exit;

            Debug.Log($"Entrou no {SceneManager.GetActiveScene().name}");
        }
        else if(SceneManager.GetActiveScene().name == "Creator")
        {

            Debug.Log($"Entrou no {SceneManager.GetActiveScene().name}");
        }
        else if(SceneManager.GetActiveScene().name == "Editor")
        {

            Debug.Log($"Entrou no {SceneManager.GetActiveScene().name}");
        }
        else if(SceneManager.GetActiveScene().name == "Viwer")
        {

            Debug.Log($"Entrou no {SceneManager.GetActiveScene().name}");
        }
    }

    void Editer()
    {
        SceneManager.LoadScene("Editor");
    }

    void Creator()
    {
        SceneManager.LoadScene("Creator");
    }

    void Viwer()
    {
        SceneManager.LoadScene("Viwer");
    }

    void Exit()
    {
        Application.Quit();
    }
}
