using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace tic_toe
{
    public class GameManager : MonoBehaviour
    {
        public TicTacToeManager Tick;
        public Button Play;
        public Button PlayAI;


        private void OnEnable()
        {
            Play.onClick.AddListener(StartGame);
            PlayAI.onClick.AddListener(StartGameAI);
        }


        void StartGame()
        {
            
            Tick.UpdatePlayType((int)PlayTime.OPPONENT);
            Tick.AI = false;
        }

        void StartGameAI()
        {
            Tick.UpdatePlayType((int)PlayTime.AI);
            Tick.AI = true;
            Tick.currentTick = TICK.CIRCLE;
        }

        private void OnDisable()
        {
            Play.onClick.RemoveListener(StartGame);
            PlayAI.onClick.RemoveListener(StartGameAI);
        }


        public void ReloadLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}