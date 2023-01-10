using DG.Tweening;
using UnityEngine;

public class GameManager : MonoBehaviour{
    public static float GameSpeed => _gameSpeed;
    private static float _gameSpeed = 1;

    public static int CurrentShrooms;

    private static GameManager _instance;

    private void Awake(){
        if (_instance == null)
            _instance = this;
    }

    public static void SlowDownTime(float percent, float duration){
        _gameSpeed = percent;
        
        _instance.Invoke(nameof(ResetGameSpeed), duration);
    }

    public static void SlowDownTime(float percent, float duration, AnimationCurve curve){
        _gameSpeed = percent;
        DOTween.To(() => _gameSpeed, value => _gameSpeed = value, 1, duration).SetEase(curve);
    }


    private static void ResetGameSpeed(){
        _gameSpeed = 1;
    }
}