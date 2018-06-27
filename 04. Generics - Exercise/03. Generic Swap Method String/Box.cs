namespace _03._Generic_Swap_Method_String
{
    public class Box<T>
    {
        public Box()
        {
            this.Value = default(T);
        }

        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public override string ToString()
        {
            return $"{this.Value.GetType()}: {this.Value}";
        }
    }
}