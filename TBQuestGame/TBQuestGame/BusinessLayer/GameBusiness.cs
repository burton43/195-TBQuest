﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.BusinessLayer;
using TBQuestGame.Models;
using TBQuestGame.DataLayer;
using TBQuestGame.PresentationLayer;

namespace TBQuestGame.BusinessLayer
{
    public class GameBusiness
    {
        GameSessionViewModel _gameSessionViewModel;
        bool _newPlayer = true; 
        Player _player = new Player();
        PlayerSetupView _playerSetupView = null;
        List<string> _messages;

        private void SetupPlayer()
        {
            if (_newPlayer)
            {
                _playerSetupView = new PlayerSetupView(_player);
                _playerSetupView.ShowDialog();

           
                _player._scared = false;
                
            }
            else
            {
                _player = GameData.PlayerData();
            }
        }

        public GameBusiness()
        {
            SetupPlayer();
            InitializeDataSet();
            InstantiateAndShowView();
        }

        private void InitializeDataSet()
        {
            
            _messages = GameData.InitialMessages();
        }

        private void InstantiateAndShowView()
        {
            _gameSessionViewModel = new GameSessionViewModel( _player, _messages);
            GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

            gameSessionView.DataContext = _gameSessionViewModel;

            gameSessionView.Show();
            _playerSetupView.Close();
        }
    }
}
