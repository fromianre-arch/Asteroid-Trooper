using UnityEngine;
using System;
using System.Collections;

public class DeathDestroyManager : Death
{
    private Obstacle obstacleToRemove;
    private Bullet bulletToRemove;
    public int someScoreValue = 10;

    public override void Die()
    {
        AsteroidBreak asteroidBreak = GetComponent<AsteroidBreak>();
        if (asteroidBreak != null)
        {
            asteroidBreak.Break();
        }
        if (GameManager.someGameManager != null)
        {
            if (GameManager.someGameManager.obstacleList != null && obstacleToRemove != null)
            {
                GameManager.someGameManager.obstacleList.Remove(obstacleToRemove);
            }
            GameManager.someGameManager.someScore += someScoreValue;
            GameManager.someGameManager.someStatusMsg.text = $"Obtained {someScoreValue} points, total is now {GameManager.someGameManager.someScore}";
            if (GameManager.someGameManager.bulletList != null)
            {
                GameManager.someGameManager.bulletList.Remove(bulletToRemove);
                //convert our string to an int
                string numberString = GameManager.someGameManager.someBulletValue.text;
                int number = Convert.ToInt32(numberString);
                number += 1;
                GameManager.someGameManager.someBulletValue.text = number.ToString();
            }
        }
        //removes gameobject from scene.
        Destroy(gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        obstacleToRemove = GetComponent<Obstacle>();
        bulletToRemove = GetComponent<Bullet>();
    }
}
