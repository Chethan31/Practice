List<int> numbers = new List<int>();

numbers.Add(0);//write
numbers.Add(1);

for(int i = 0; i < numbers.Count; i++)
{
    numbers.Add(numbers[i]);
}

foreach (int item in numbers)
    Console.WriteLine(item);

Console.WriteLine(numbers[1]);

numbers.Insert(10, 1000);//insert at index value
numbers.RemoveAt(10);//remove at index value
numbers.Sort();//sort


Queue<int> q = new Queue<int>();
q.Enqueue(10);//write
q.Dequeue();//read and delete
q.Peek();//read

Stack<int> s = new Stack<int>();
s.Push(10);//write
s.Pop();//read and delete
s.Peek();//read

HashSet<int> set = new HashSet<int>();  
set.Add(10);//write
set.Remove(10);//delete

Dictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(60, "pass");
dict.Add(62, "Fail");
string r = dict[60];