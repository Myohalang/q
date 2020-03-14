using System;
using System.Collections;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex011
    {
        public void Run()
        {
            Hashtable hst = new Hashtable();

            hst.Add("korea", "한국");
            hst.Add("japan", "일본");
            hst.Add("brazil", "브라질");
            hst.Add("china", "중국");
            hst.Add("canada", "캐나다");
            hst.Add("america", "미국");
            hst.Add("spain", "스페인");

            while (true)
            {
                Write("단어를 입력하세요. (Q:종료) : ");
                string word = ReadLine().ToLower();

                if ("q" == word)
                {
                    return;
                }

                if (hst.Contains(word))
                {
                    WriteLine($"{word}, {hst[word]}");

                    Write($"{word}를 삭제하시겠습니까? (YES / NO) : ");

                    string delete = ReadLine().ToLower();

                    if ("yes" == delete)
                    {
                        hst.Remove(word);

                        WriteLine($"{word}를 삭제했습니다.");
                    }
                    else if ("no" == delete)
                    {
                        continue;
                    }
                    else
                    {
                        WriteLine("잘못된 입력입니다.");
                        continue;
                    }
                }
                else
                {
                    WriteLine("단어가 없습니다.");

                    Write($"{word}를 추가하시겠습니까? (YES / NO) : ");

                    string add = ReadLine().ToLower();

                    if ("yes" == add)
                    {
                        WriteLine("단어의 뜻을 입력하세요");
                        string mean = ReadLine();

                        hst.Add(word, mean);

                        WriteLine("단어를 추가했습니다.");
                    }
                    else if ("no" == add)
                    {
                        continue;
                    }
                    else
                    {
                        WriteLine("잘못된 입력입니다.");
                        continue;
                    }
                }
            }
        }
    }
}
