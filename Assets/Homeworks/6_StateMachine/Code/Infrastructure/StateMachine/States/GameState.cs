using System.Threading.Tasks;
using UnityEngine;

namespace StateMachine
{
    public class GameState : IState
    {
        public void Enter()
        {
            Debug.Log("Game State");
        }

        public void Exit()
        {

        }
    }
}