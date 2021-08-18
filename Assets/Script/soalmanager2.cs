using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soalmanager2 : MonoBehaviour
{
    [System.Serializable]
    // Start is called before the first frame update

    public class Soal
    {
        [TextArea]
        [Header("Soal")]
        public string soal;

        [Header("Pilihan untuk Jawaban")]
        public string pilA;
        public string pilB, pilC, pilD;

        [Header("Kunci Jawaban")]
        public bool A;
        public bool B, C, D;
    }

    public GameObject selesai;
    Text textSoal, textA, textB, textC, textD;
    public int nilaiAcak;
    public int skor;
    public List<Soal> KumpulanSoal;
    void Start()
    {
        textSoal = GameObject.Find("TextSoal").GetComponent<Text>();
        textA = GameObject.Find("A").GetComponent<Text>();
        textB = GameObject.Find("B").GetComponent<Text>();
        textC = GameObject.Find("C").GetComponent<Text>();
        textD = GameObject.Find("D").GetComponent<Text>();

        nilaiAcak = Random.RandomRange(0, KumpulanSoal.Count);
    }

    // Update is called once per frame
    void Update()
    {
        if (KumpulanSoal.Count > 0)
        {
            textSoal.text = KumpulanSoal[nilaiAcak].soal;
            textA.text = KumpulanSoal[nilaiAcak].pilA;
            textB.text = KumpulanSoal[nilaiAcak].pilB;
            textC.text = KumpulanSoal[nilaiAcak].pilC;
            textD.text = KumpulanSoal[nilaiAcak].pilD;
        }
        else
        {
            selesai.SetActive(true);
            textSoal.text = "Skor: " + skor;
            GameObject.Find("buttonab").SetActive(false);
            GameObject.Find("buttoncd").SetActive(false);

        }


    }


    public void cekJawaban(string jawaban)
    {
        if (KumpulanSoal[nilaiAcak].A == true && jawaban == "a")
        {
            skor += 20;
        }

        if (KumpulanSoal[nilaiAcak].B == true && jawaban == "b")
        {
            skor += 20;
        }

        if (KumpulanSoal[nilaiAcak].C == true && jawaban == "c")
        {
            skor += 20;
        }

        if (KumpulanSoal[nilaiAcak].D == true && jawaban == "d")
        {
            skor += 20;
        }
        KumpulanSoal.RemoveAt(nilaiAcak);
        nilaiAcak = Random.RandomRange(0, KumpulanSoal.Count);
    }

    public void ulang()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
