using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interaction : MonoBehaviour
{
    TextMeshPro _textmesh;
    string[] _textCharacters;
    public bool isActive;
    public float timeSecs;
    float _timer;
    int _charCount;
    // Start is called before the first frame update
    void Start()
    {
        _textmesh = GetComponent<TextMeshPro>();
        _textCharacters = new string[_textmesh.text.Length];
        for(int i = 0; i < _textmesh.text.Length; i++){
            _textCharacters[i] = _textmesh.text.Substring(i,1);
        }
        _textmesh.text = "";
        _charCount = 0;
        _timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 1){
            if(Input.GetTouch(0).phase == TouchPhase.Began){
                isActive=true;
            }
        }
        if(isActive){
            if(_charCount < _textCharacters.Length){
                _timer += Time.deltaTime;
                if (_timer >= timeSecs){
                    _textmesh.text = _textCharacters[_charCount];
                    _charCount++;
                    _timer = 0;
                }
            }
            if(_charCount == _textCharacters.Length){
                if(transform.childCount > 0){
                    transform.GetChild(0).GetComponent<Interaction>().isActive = true;
                    _charCount++;
                }
            }
        }   
    }
}
