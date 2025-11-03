using Zenject;

namespace StateMachine
{
    public class Bootstraper : IInitializable
    {
        private StateMachine _stateMachine;
        private BootstrapState _bootstrapState;

        public Bootstraper(StateMachine stateMachine, BootstrapState bootstrapState)
        {
            _stateMachine = stateMachine;
            _bootstrapState = bootstrapState;
        }

        public void Initialize()
        {
            _bootstrapState.InitializeCompleted += GameState;
            _stateMachine.Enter<BootstrapState>();
        }

        private void GameState()
        {
            _stateMachine.Enter<GameState>();
        }
    }
}