using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class EfeitoDigitando : MonoBehaviour
{
    private TextMeshProUGUI componenteTexto;
    private AudioSource _audiosource;
    private string mensagemOriginal;
    public bool imprimindo;
    public float TempoEntreLetras = 0.08f;
    
    private void Awake()
    {
        TryGetComponent(out componenteTexto);
        TryGetComponent(out _audiosource);
        mensagemOriginal = componenteTexto.text;
        componenteTexto.text = "";
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        componenteTexto.text = mensagemOriginal;
    }

    public void imprimirMensagem(string mensagem)
    {

    }

    IEnumerator LetraPorLetra(string mensagem)
    {
        string msg = "";
        foreach(var letra in mensagem)
        {
            msg += letra;
            componenteTexto.text = msg;
            _audiosource.Play();
            yield return new WaitForSeconds(TempoEntreLetras);
        }
    }
}
