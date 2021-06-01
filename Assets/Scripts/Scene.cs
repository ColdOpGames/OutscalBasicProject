using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
enum SceneName
{
    Master,
    One,
    Two,
    Three
};
public class Scene : MonoBehaviour
{
    [SerializeField]
    private SceneName SceneName;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(onClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void onClick()
    {
        SceneManager.LoadScene(((int)SceneName));
    }
}
