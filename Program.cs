namespace ShopMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("header");
            {
                Console.WriteLine("헤더입니다");  // A#2
                Console.WriteLine("회원가입");    // B#4
                Console.WriteLine("about");      // A#8
                Console.WriteLine("관리자");      // B#6
            }
            Console.WriteLine("article");
            {
                Console.WriteLine("본문입니다");  // A#3
                Console.WriteLine("기사1");      // A#5
                Console.WriteLine("기사2");      // A#5
                Console.WriteLine("New본문");    // B#10
                Console.WriteLine("보충기사");    // A#11
            }
            Console.WriteLine("footer");
            {
                Console.WriteLine("푸터입니다");  // A#3
            }
        }

    }
}