using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class BelajarCSharp : MonoBehaviour
{
    //intger = bilangan bulat
    [SerializeField] private int bilanganBulat = 10;

    //kalimat = string
    private string kalimat = "hai aku aan";

    //pecahan atau bukan bulat
    private float pecahan = 2.5f;

    [SerializeField] private GameObject Player;

    // Start is called before the first frame update
    private void Start()
    {
        // Debug.Log("Hai");
        // Debug.Log("Coyy");
        // Debug.Log("Coba ucapkan ini, " + kalimat);
        // Debug.Log("Isi dari variabel bilangan bulat adalah " + bilanganBulat);
        // Debug.Log("Aku punya ayam sebanyak " + bilanganBulat*2);
        // Debug.Log("Aku punya ayam sebanyak " + pecahan*2);
        // PerkenalkanDiri();

        Player.SetActive(false);
    }

    public void PerkenalkanDiri()
    {
        Debug.Log("Hai aku aan");
        Debug.Log("aku dari pemalang");
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log("Emon");
    }
}
