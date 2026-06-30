using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
//using UnityEngine.AddressableAssets;

public class GameController : MonoBehaviour
{
    [SerializeField] List<Beys> bladeS = new List<Beys>();

    [SerializeField] List<Beys> bladeU = new List<Beys>();

    [SerializeField] List<Beys> bladeO = new List<Beys>();

    [SerializeField] List<Beys> bladeM = new List<Beys>();

    [SerializeField] List<Beys> bladeA = new List<Beys>();


    //Aqui vai ficar a parte em que o sistema vai colocar os scriptable objects dentro das listas atraves do addressable
    void Awake()
    {
        Addressables.LoadAssetsAsync<Beys>("BBlade", Mblades => bladeS.Add(Mblades)).Completed += OnLoaded;
        Addressables.LoadAssetsAsync<Beys>("UBlade", bladeu => bladeU.Add(bladeu)).Completed += OnLoaded;
        Addressables.LoadAssetsAsync<Beys>("Over", Oblade => bladeO.Add(Oblade)).Completed += OnLoaded;
        Addressables.LoadAssetsAsync<Beys>("Assist", Ablade => bladeA.Add(Ablade)).Completed += OnLoaded;
        Addressables.LoadAssetsAsync<Beys>("MainBlade", Mblade => bladeM.Add(Mblade)).Completed += OnLoaded;
    }

    void OnLoaded(AsyncOperationHandle<IList<Beys>> handle)
    {
        if(handle.Status == AsyncOperationStatus.Succeeded)
        {
            for(int i = 0; i < bladeS.Count; i++)
            {
                Debug.Log($"Blade: {bladeS[i].NameP()}");
            }

            for(int i = 0; i < bladeU.Count; i++)
            {
                Debug.Log($"Blade UX: {bladeU[i].NameP()}");
            }

            for(int i = 0; i < bladeA.Count; i++)
            {
                Debug.Log($"Assist Blade: {bladeA[i].NameP()}");
            }

            for(int i = 0; i < bladeO.Count; i++)
            {
                Debug.Log($"Over Blade: {bladeO[i].NameP()}");
            }

            for(int i = 0; i < bladeM.Count; i++)
            {
                Debug.Log($"Main Blade: {bladeM[i].NameP()}");
            }
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
