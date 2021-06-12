using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour
{
    public Movement mmt;
    public Rigidbody playerRigid;
    GameObject[] collided;
    public Score Sc;

    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
        mmt = FindObjectOfType<Movement>();
        Sc = FindObjectOfType<Score>();
        collided = GameObject.FindGameObjectsWithTag("whencollide");
        hidewhencollided();
    }
    private void FixedUpdate()
    {
        float altitude = playerRigid.transform.position.y;
        if (altitude <= 0)
        {
            playerRigid.isKinematic = true;
            Sc.enabled = false;
            //RestartGame();
            showwhencollided();
        }

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Obstacle")
        {
            mmt.enabled = false;
            //playerRigid.constraints = RigidbodyConstraints.FreezeAll;
            Sc.enabled = false;
            //FindObjectOfType<GameManager>().Restart();
            //RestartGame();
            showwhencollided();

            }
        if(other.collider.tag == "NextLevel")
        {
            mmt.enabled = false;
            FindObjectOfType<Score>().nextlevel();
            FindObjectOfType<GameManager>().NextLevel();
        }
        if (other.collider.tag == "Gameover")
        {
            mmt.enabled = false;
            FindObjectOfType<GameManager>().GameEnd();
        }
    }
    /*public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }*/
    
    public void hidewhencollided()
    {
        foreach (GameObject g in collided)
        {
            g.SetActive(false);
        }
    }
    public void showwhencollided()
    {
        foreach (GameObject g in collided)
            {
                g.SetActive(true);
            }
    }

}
