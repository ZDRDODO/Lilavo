using System;

namespace List
{
    public class CustomArrayList

    {

        private object[] arr;



        private int count;

        public int Count

        {

            get

            {

                return count;

            }

        }



        private static readonly int INITIAL_CAPACITY = 4;

        public CustomArrayList()

        {

            arr = new object[INITIAL_CAPACITY];

            count = 0;

        }
        public void Add(object item)

        {

            Insert(count, item);

        }

        public void Insert(int index, object item)

        {

            if (index > count || index < 0)

            {

                throw new IndexOutOfRangeException(

                      "Invalid index: " + index);

            }

            object[] extendedArr = arr;

            if (count + 1 == arr.Length)

            {

                extendedArr = new object[arr.Length * 2];

            }

            Array.Copy(arr, extendedArr, index);

            count++;

            Array.Copy(arr, index, extendedArr, index + 1, count - index - 1);

            extendedArr[index] = item;

            arr = extendedArr;

        }

        public int IndexOf(object item)

        {

            for (int i = 0; i < arr.Length; i++)

            {

                if (item == arr[i])

                {

                    return i;

                }

            }



            return -1;

        }



        public void Clear()

        {

            arr = new object[INITIAL_CAPACITY];

            count = 0;

        }




        public bool Contains(object item)

        {

            int index = IndexOf(item);

            bool found = (index != -1);

            return found;

        }

        public object this[int index]

        {

            get

            {

                if (index >= count || index < 0)

                {

                    throw new ArgumentOutOfRangeException(

                          "Invalid index: " + index);

                }

                return arr[index];

            }

            set

            {

                if (index >= count || index < 0)

                {

                    throw new ArgumentOutOfRangeException(

                          "Invalid index: " + index);

                }

                arr[index] = value;

            }

        }

        public object Remove(int index)

        {

            if (index >= count || index < 0)

            {

                throw new ArgumentOutOfRangeException(

                      "Invalid index: " + index);

            }



            object item = arr[index];

            Array.Copy(arr, index + 1, arr, index, count - index + 1);

            arr[count - 1] = null;

            count--;



            return item;

        }

        public int Remove(object item)

        {

            int index = IndexOf(item);

            if (index == -1)

            {

                return index;

            }



            Array.Copy(arr, index + 1, arr, index, count - index + 1);

            count--;



            return index;

        }
        public static void Main()

        {

            CustomArrayList shoppingList = new CustomArrayList();

            shoppingList.Add("Milk");

            shoppingList.Add("Honey");

            shoppingList.Add("Olives");

            shoppingList.Add("Beer");

            shoppingList.Remove("Olives");

            Console.WriteLine("We need to buy:");

            for (int i = 0; i < shoppingList.Count; i++)

            {

                Console.WriteLine(shoppingList[i]);

            }

            Console.WriteLine("Do we have to buy Bread? " +

                  shoppingList.Contains("Bread"));

        }


    }
}
