using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

+namespace _6.StatePattern
{
    public interface IState
    {
        void OnEnter(GameContext gamecontext);
        void OnExit(GameContext gamecontext);
    }
    public interface IContext
    {
        UpdateState(IContext context);
    }
    public interface ICurrentState
    {

    }

    public class GameContext : IContext
    {
        public IState CurrentState { get; set; }
        public void UpdateContext()
        {
            throw new NotImplementedException();
        }

        public void ChangeState(IState state)
        {
            CurrentState.OnExit(this);
            CurrentState = state;
            CurrentState.OnEnter(this);
        }

        public void UpdateState(IContext context)
        {
           
        }
    }
}

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
