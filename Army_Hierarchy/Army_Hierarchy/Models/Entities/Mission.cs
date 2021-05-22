namespace Army_Hierarchy.Models.Entities
{
    using System;
    using Army_Hierarchy.Enumerators;
    using Army_Hierarchy.Models.Contracts;

    public class Mission : IMission
    {
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = CheckingInput(state);
        }

        public string CodeName { get; private set; }

        public State State { get; private set; }

        public void CompleteMission()
        {
            this.State = State.Finished;
        }

        private State CheckingInput(string state)
        {
            State currentState;
            if (!Enum.TryParse<State>(state, out currentState))
            {
                throw new InvalidOperationException();
            }

            return currentState;
        }
    }
}
