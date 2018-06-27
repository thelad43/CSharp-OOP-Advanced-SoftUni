namespace _02._Generic_Box_of_Integer
{
    public class Box<T>
    {
        private readonly T value;

        public Box(T value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"{this.value.GetType()}: {this.value}";
        }
    }
}