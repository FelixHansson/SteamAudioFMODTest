using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneTest : MonoBehaviour
{
    [SerializeField] private int mSceneIndex = 0;

    private int mCurrentSceneIndex;

    private void Awake()
    {
        mCurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.I))
        {
            mCurrentSceneIndex = mSceneIndex;

            SceneManager.LoadScene(mSceneIndex);
        }
        else if (Input.GetKeyUp(KeyCode.P))
        {
            ++mCurrentSceneIndex;

            if (mCurrentSceneIndex == SceneManager.sceneCountInBuildSettings)
            {
                mCurrentSceneIndex = 0;
            }

            SceneManager.LoadScene(mCurrentSceneIndex);
        }
        else if (Input.GetKeyUp(KeyCode.O))
        {
            --mCurrentSceneIndex;

            if(mCurrentSceneIndex == -1)
            {
                mCurrentSceneIndex = SceneManager.sceneCountInBuildSettings - 1;
            }

            SceneManager.LoadScene(mCurrentSceneIndex);
        }
    }
}