using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bucamStart12
{
    class Program
    {
        static void Main(string[] args)
        {
            //사용자 입력을 문자열 받기
            //Console.Write("이름을 입력하세요 : ");
            //string userName = Console.ReadLine(); //사용자로부터 입력 받기

            //Console.WriteLine($"안녕하세요, {userName}님!");

            //문자열을 정수로 변환
            //Console.Write("나이를 입력하세요: ");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);

            //Console.WriteLine($"내년에는 {age + 1} 살이 되겠군요!");

            Console.WriteLine("루인 스킬 피해를 작성하세요 : ");
            string inputSkill = Console.ReadLine();
            float skill = float.Parse(inputSkill);
            Console.WriteLine("카드 게이지 획득량을 작성하세요 : ");
            string inputGage = Console.ReadLine();
            float Gage = float.Parse(inputGage);
            Console.WriteLine("각성기 피해를 작성하세요 : ");
            string inputArousal = Console.ReadLine();
            float Arousal = float.Parse(inputArousal);
            Console.WriteLine("최대 마나를 작성하세요 : ");
            string inputMaxmana = Console.ReadLine();
            float Maxmana = float.Parse(inputMaxmana);
            Console.WriteLine("전투 중 마나 회복량를 작성하세요 : ");
            string inputWarmana = Console.ReadLine();
            float Warmana = float.Parse(inputWarmana);
            Console.WriteLine("비전투 중 마나 회복량를 작성하세요 : ");
            string inputNowarmana = Console.ReadLine();
            float Nowarmana = float.Parse(inputNowarmana);
            Console.WriteLine("이동속도를 작성하세요 : ");
            string inputSpeed = Console.ReadLine();
            float Speed = float.Parse(inputSpeed);
            Console.WriteLine("탈 것 속도를 작성하세요 : ");
            string inputRide = Console.ReadLine();
            float Ride = float.Parse(inputRide);
            Console.WriteLine("운반 속도를 작성하세요 : ");
            string inputTrnsp = Console.ReadLine();
            float Trnsp = float.Parse(inputTrnsp);
            Console.WriteLine("스킬 재사용 대기시간 감소를 작성하세요 : ");
            string inputReskill= Console.ReadLine();
            float Reskill = float.Parse(inputReskill);

            Console.Clear();

            Console.WriteLine("루인 스킬 피해 : " + skill + "%");
            Console.WriteLine("카드 게이지 획득량 : " + Gage + "%");
            Console.WriteLine("각성기 피해 : " + Arousal + "%");
            Console.WriteLine("최대 마나 : " + Maxmana);
            Console.WriteLine("전투 중 마나 회복량 : " + Warmana);
            Console.WriteLine("비전투 중 마나 회복량: " + Nowarmana);
            Console.WriteLine("이동 속도 : " + Speed + "%");
            Console.WriteLine("탈 것 속도 : " + Ride + "%");
            Console.WriteLine("운반 속도 : " + Trnsp + "%");
            Console.WriteLine("스킬 재사용 대기시간 감소 : " + Reskill + "%");

        }
    }
}
