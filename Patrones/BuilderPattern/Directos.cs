namespace WebPatrones.BuilderPattern
{
    public class Director
    {
        private IBuilder _builder;
        
        public void Construct(IBuilder builder)
        {
            this._builder = builder;
            builder.StartUpOperations();
            builder.InsertWheels();
            builder.AddHeadLights();
            builder.EndOpererations();

        }
        
        
        
    }
    
    
    
}