using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
   /* public Animator transition;
    public float transitionTime = 1f;
    
    //used to load public methods from the EnemySpawningScript
    EnemySpawning neededScript;

    // Start is called before the first frame update
    void Start()
    {
        neededScript = GameObject.FindGameObjectWithTag("LevelLoader").GetComponent<EnemySpawning>();
    }

    // Update is called once per frame
    void Update()
    {
        if(neededScript.waveCompleted() == 1) 
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel() 
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex) 
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);*/
    
}
