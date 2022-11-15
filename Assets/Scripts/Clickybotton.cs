using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Clickybotton : MonoBehaviour,IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Image _img;
    [SerializeField] private Sprite _default, _pressed;
    [SerializeField] private AudioClip _compressclip, _uncompressedclip;
    [SerializeField] private AudioSource _source;
    public void OnPointerDown(PointerEventData eventData)
    {
       
        if (_img.sprite.name == "nosound" || _img.sprite.name == "novibrattion")
        {
            _img.sprite = _default;
            _source.PlayOneShot(_compressclip);
            _source.PlayOneShot(_uncompressedclip);
        }
        else if (_img.sprite.name == "audio_100px" || _img.sprite.name == "shake_phone_100px")
        {
            _img.sprite = _pressed;
            _source.PlayOneShot(_compressclip);
            _source.PlayOneShot(_uncompressedclip);
        }
        else if (_img.sprite.name != "nosound" && _img.sprite.name != "novibrattion" && _img.sprite.name != "audio_100px" && _img.sprite.name != "shake_phone_100px")
        {
            _img.sprite = _pressed;
            _source.PlayOneShot(_compressclip);
        }

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        
        if (_img.sprite.name != "nosound" && _img.sprite.name != "novibrattion" && _img.sprite.name != "audio_100px" && _img.sprite.name != "shake_phone_100px")
        {
            _img.sprite = _default;
            _source.PlayOneShot(_uncompressedclip);
        }


    }

}
