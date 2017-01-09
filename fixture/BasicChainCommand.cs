namespace ChainCommand.Test.fixture
{
    public class BasicChainCommand : BaseChainCommand
    {
        public override void Execute()
        {
            base.Execute();
            done();
        }
    }
}