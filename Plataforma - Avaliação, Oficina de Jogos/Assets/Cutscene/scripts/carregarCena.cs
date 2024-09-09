using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carregarCena : MonoBehaviour
{

    public string CenaParaCarregar;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(CenaParaCarregar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
