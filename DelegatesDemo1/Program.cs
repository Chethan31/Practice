namespace DeleagtesDemo1
{
    //step 1: declare the delegate --creating a class and extenting from Multidelegate
    delegate void MyDelegate(string msg);

     public class Program
     {
        public static void Main()
        {
            //Step 2: Instantiate and initialize
            MyDelegate d1 = new MyDelegate(Greeting);
            Program p1 = new Program();
            d1 += p1.Hello;//Subscribe
            d1 -= Greeting;
            
            //Step 3:Invoke
            
            //Direct call
           // Greeting("Direct Call");
            //1.indirect call
           // d1.Invoke("Indirect Call 1");
            //2.indirect call
            d1("Indirect Call 2");
        }
        static void Greeting(string msg)
        {
            Console.WriteLine("Greeting:"+msg);
        }
        void Hello(string msg)
        {
            Console.WriteLine("Hello:"+msg);
        } 
    }
}