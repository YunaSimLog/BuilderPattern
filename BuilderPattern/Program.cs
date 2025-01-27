using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 빌더 클래스 전용 리스트 생성
            List<StudentBuilder> builders = new List<StudentBuilder>();

            // 2. 객체를 최종 생성 하지말고 초기값만 세팅한 빌더 생성
            builders.Add(
                new StudentBuilder(20250101)
                    .Name("홍길동")
            );

            builders.Add(
                new StudentBuilder(20250102)
                .Name("임꺽정")
                .Grade("햇님반")
            );

            builders.Add(
                new StudentBuilder(20250103)
                .Name("유관순")
                .Grade("달님반")
                .Phone("010-0000-0000")
            );

            // 3. 나중에 빌더 리스트를 순회하여 최종 객체 생성을 주도
            for (int i = 0; i < builders.Count; i++)
            {
                Student student = builders[i].Build();
            }
        }
    }
}

