using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject aloitusRuutu;
    public GameObject valintaRuutu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Aloita()
    {
        aloitusRuutu.SetActive(false);
        valintaRuutu.SetActive(true);
    }
}
