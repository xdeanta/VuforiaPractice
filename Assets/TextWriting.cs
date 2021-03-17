using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextWriting : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshPro GUItext;
    public float tChar;
    private string story;
    int indChar;
    bool active;
    float timer;
    void Start()
    {
        story = "«Denuncia do equilibrio», publicado en 1986 a contracorrente da poesía galega daquel momento, é un libro rabiosamente contemporáneo. Cuestiona a orde establecida, afonda con inquedanza na voz interior dunha poeta orixinal e libre e transmite, desde a propia sintaxe, o desacougo da vida cotiá, das emocións e do amor. Este primeiro libro de poemas de Xela Arias dá conta do arrebato dunha voz nova, independente, radicalmente propia, que se pon en marcha cunha enorme forza simbólica. Como di a poeta Olga Novo no limiar en «Denuncia do equilibrio» está «a altura, o precipicio, a conmoción».";

    }

    void Update()
    {
        if(active){
            timer = timer - Time.deltaTime;
            if(timer <= 0f){
                timer = timer + tChar;
                if(indChar <= story.Length){
                    GUItext.text = story.Substring(0,indChar);
                    indChar++;
                }

            }
        }
    }

    public void onFocus(){
        //Debug.Log("story: " + story);
        active=true;
    }

    public void onLost(){
        //story = GUItext.text;
        GUItext.text = "";
        active = false;
        indChar=1;
        timer = 0;
    }

}
