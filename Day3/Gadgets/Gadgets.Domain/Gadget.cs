namespace Gadgets.Domain
{
    public class Gadget : EntityBase
    {
        public string Name { get; set; }

        public double Weight { get; set; }

        public GadgetType Type { get; set; }

    }
}
