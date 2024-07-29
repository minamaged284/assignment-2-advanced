namespace assignment_2
{
    public class FixedSizeList<T>
    {
        public List<T> fixedSizeList = new List<T>();

        public int Capacity { get; set; }
        public FixedSizeList(int capacity)
        {
            if (capacity < 0 || capacity == null)
            {
                capacity = 0;
            }

            else
            {
                Capacity = capacity;
            }
        }

        public void add(T item)
        {
            if (fixedSizeList.Count < Capacity)
            {
                fixedSizeList.Add(item);
            }

            else
            {
                throw new ArgumentException("the list is already full");
            }

        }

        public T get(int index)
        {
            if (index >= 0 && index <= Capacity)
            {
                return fixedSizeList[index];
            }
            else { throw new ArgumentException("index is not valid"); }
        }

        public override string ToString()

        {
            string? content = "";

            if (fixedSizeList != null)
            {
                foreach (T item in fixedSizeList)
                {

                    content += item.ToString()+"\n";
            }
            }
            else { content = string.Empty; }

            return content;
        }
    }
}
