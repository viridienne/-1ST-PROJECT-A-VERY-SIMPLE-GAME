using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //animation
    [SerializeField]
    private Animator _anim;

    //basic data
    [SerializeField]
    private float _speed;
    [SerializeField]
    private int _score;
    [SerializeField]
    private int _lives;

    [SerializeField]
    private Slider _healthbar;

    //spawner
    [SerializeField]
    private Spawner _spawner;

    //canvas
    [SerializeField]
    private CanvasController _canvasCtrl;
    [SerializeField]
    bool isDead;

    //audio
    [SerializeField]
    private AudioSource _audio;
    [SerializeField]
    private AudioClip _scoreSound;
    [SerializeField]
    private AudioClip _damageSound;

    [SerializeField]
    private PlayerConfig _configdata;

    [SerializeField]
    private float _time;

    public int Lives
    {
        get => _lives;
        set
        {
            _lives = value;
            if(_lives==0)
            {
                isDead = true;
                
                _anim.SetTrigger("isDead");
                _canvasCtrl.ShowGameOverUI();

                Time.timeScale = 0f;//=>pause game
                PlayerPrefs.SetFloat("time", _time);//=>save played time
            }
            _canvasCtrl.SetLives(Lives);
        }
    }
    public int Score
    {
        get => _score;
        set
        {
            _score = value;
            _canvasCtrl.SetScore(Score);
            PlayerPrefs.SetInt("score", _score);//=>save score;
        }
    }

    void Start()
    {
        _anim.SetBool("isIdle", true);
        _anim.SetBool("isLeft", false);

        _speed = _configdata.Speed;
        _lives = _configdata.Lives;

        _canvasCtrl.SetScore(Score);
        _canvasCtrl.SetLives(Lives);
    }

    // Update is called once per frame
    void Update()
    {
        //if(isDead)
        //{
        //    Time.timeScale = 0f; //pause game
        //}
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
            _anim.SetBool("isIdle", false);
            _anim.SetBool("isLeft", false);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
            _anim.SetBool("isIdle", false);
            _anim.SetBool("isLeft", true);
        }
        else
        {
            _anim.SetBool("isIdle", true);
        }
        _time += Time.deltaTime;
    }

    // OnTriggerEnter2D is called when the Collider2D other enters the trigger (2D physics only)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Score"))
        {
            Score += 10;
            _audio.PlayOneShot(_scoreSound);
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.CompareTag("Trigger"))
        {
            Debug.Log("Reached Item Trigger");
            _spawner.Spawn();
        }
        else
        {
            Lives -= 1;
            _audio.PlayOneShot(_damageSound);
            _healthbar.value = _lives;
            Destroy(collision.gameObject);
        }
    }
    [ContextMenu("Test_DeadState")]
    
    private void Test_DeadState()
    {
        Lives -=_lives;
    }

}
