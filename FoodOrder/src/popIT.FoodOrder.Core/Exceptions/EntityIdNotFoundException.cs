namespace popIT.FoodOrder.Core.Exceptions
{
    public class EntityIdNotFoundException : FoodOrderException
    {
        public EntityIdNotFoundException(string modelName, int id)
        {
            ModelName = modelName;
            Id = id;
        }

        public string ModelName { get; }

        public int Id { get; }

        public override string Message => $"Entity {ModelName} with id {Id} not found";
    }
}