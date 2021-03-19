using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextWriting3 : MonoBehaviour
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
        story = "O poemario Darío a diario non naceu coa vocación de se lo que hoxe é: un libro encadernado e público. Foi, no seu principio, a necesidade imperiosa de explicarlle ó meu fillo o manifesto íntimo e interno de intencións maternas nas que el mesmo, polo feito de existir, me obrigaba a moverme; o compendio de contradiccións que a maternidade me provoca. Somos mulleres: prestámo-lo noso corpo para que nel se desenvolva un ser intrínseco a nós e ó mesmo tempo independente de nós, alleo a nós; ata aí a función biolóxica da propia muller. Mais despois a criatura chega ó mundo, e velaquí que se dan as diferentes maneiras de vivi-lo que se chama maternidade, a que parte principalmente da obriga social da cría nos primeiros tempos: non podemos esquecelo, a maternidade así é un feito cultural, social, non intrínseco á muller, aínda que si exercido durante séculos e séculos. E pódese vivir seguramente de moitos xeitos: como posesión e arma de muller ou nai; como extensión de ideas ou desexos... Ou, como creo e máis cren comigo, co firme propósito de face-lo posible (e desde logo sen saber que é o posible, primeira contradicción) para axudar ou fomenta-la creación dun ser libre e independente de criterio e corpo, que saiba desenvolverse nesta sociedade ensarillada nunha andamiaxe de valores que non considero nin liberadores nin fomentadores da independencia (segunda gran contradicción). En todo isto, só un enorme territorio sen contradicción posible: o amor eterno e incombustible, sen medo das palabras. Xela Arias.";

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
