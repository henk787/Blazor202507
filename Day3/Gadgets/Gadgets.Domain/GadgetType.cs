namespace Gadgets.Domain
{
    public class GadgetType : EntityBase
    {
        public string Name { get; set; }

        public bool IsHazardous { get; set; }

        public Supplier Supplier { get; set; }
        
    }
}
