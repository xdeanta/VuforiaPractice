using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextWriting2 : MonoBehaviour
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
        story = "Xela Arias Castaño, nació en Lugo en 1962 con el nombre de María de los Ángeles.En 1995 le autorizaron el cambio de nombre por el de Xela.\nEmpezo a trabajar en Edicións Xerais de Galicia, en 1979. Primero realizó trabajos de oficinista, después de creación e investigación y entre 1990 y 1996 como correctora de estilo y editora, además de escritora, poeta y traductora española en varios idiomas.\nEn el curso 1999-2000 comenzó a ejercer como profesora sustituta de enseñanza secundaria, de lengua y literatura castellana, en institutos de Santa Comba, Moaña, Pontevedra, Santiago de Compostela y Vigo. En sus últimos años de vida fue docente en diferentes municipios gallegos, como Chapela, A Guarda y Vigo.\n En noviembre del año 2003 Xela Arias falleció a los 41 años en un hospital de Vigo debido a un ataque cardíaco.";

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
