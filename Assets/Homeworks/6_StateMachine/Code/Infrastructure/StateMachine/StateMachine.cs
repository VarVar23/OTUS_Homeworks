using System;
using System.Collections.Generic;

namespace StateMachine
{
    public class StateMachine
    {
        private Dictionary<Type, IState> _allStates = new();
        private IState _currentState;

        public StateMachine(IEnumerable<IState> states)
        {
            foreach(var state in states)
            {
                _allStates.Add(state.GetType(), state);
            }
        }

        public void Enter<TState>() where TState : class, IState
        {
            Exit();

            _currentState = _allStates[typeof(TState)];
            _currentState.Enter();
        }

        private void Exit()
        {
            if(_currentState != null)
            {
                _currentState.Exit();
            }
        }
    }
}