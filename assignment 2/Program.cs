using System.Collections;

namespace assignment_2
{
    internal class Program
    {
        #region part 2 

        #region question 1


        static ArrayList reverseArrayList(ArrayList arrayList)
        {
            ArrayList dummy = (ArrayList)arrayList.Clone();

            for (int i = arrayList.Count - 1; i >= 0; i--)
            {
                arrayList.Add(arrayList[i]);
                arrayList.RemoveAt(i);
            }
            return arrayList;
        }
        #endregion

        #region question 2

        static List<int> even(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {


                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }


            }
            return evenNumbers;
        }

        #region question 4

        static int getIndex(string input)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dict.ContainsKey(input[i]))
                {
                    dict.Add(input[i], i);

                }

                else if (dict.ContainsKey(input[i]))
                {
                    dict.Remove(input[i]);
                }
            }
            if (dict.Count == 0)
            {
                return -1;
            }
            else
                return dict.FirstOrDefault().Value;
        }


        #endregion



        #endregion
        #endregion
        static void Main(string[] args)
        {
            #region part2
            #region question1
            ArrayList arrayList = new ArrayList()
            {
                "mina", "maged", "atya","saeed", "saweres"
            };

            reverseArrayList(arrayList);
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            #endregion


            #region question 2

            List<int> numbers = new List<int>() {

                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30
            };



            foreach (var number in even(numbers))
            {
                Console.WriteLine(number);
            }


            #endregion

            #region question 3

            FixedSizeList<int> fixedSize = new FixedSizeList<int>(5);

            fixedSize.add(1);
            Console.WriteLine(fixedSize.ToString());
            Console.WriteLine(fixedSize.ToString());

            fixedSize.add(2);


            Console.WriteLine(fixedSize.ToString());


            fixedSize.add(3);
            Console.WriteLine(fixedSize.ToString());


            fixedSize.add(4);
            Console.WriteLine(fixedSize.ToString());

            fixedSize.add(5);
            Console.WriteLine(fixedSize.ToString());
            Console.WriteLine(fixedSize.get(4));
            Console.WriteLine(fixedSize.get(5));



            fixedSize.add(6);





            #endregion



            #region question 4
            Console.WriteLine(getIndex(""));

            #endregion
            #endregion





        }
    }
}
