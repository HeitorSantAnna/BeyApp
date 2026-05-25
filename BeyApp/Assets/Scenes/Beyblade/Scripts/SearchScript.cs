using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class SearchScript : MonoBehaviour
{
    /*[SerializeField] GameObject ContentHolder;

    [SerializeField] GameObject[] Elements;

    [SerializeField] GameObject SeachNumber, SeachHeight;*/

    [SerializeField] Reched reched;

    public void Local()
    {
        
    }

    void Start()
    {
        Debug.Log($"Reched: {reched.number}-{reched.height}");
    }

    void Update()
    {
        
    }
}
