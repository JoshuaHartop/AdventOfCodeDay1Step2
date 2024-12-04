using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.IO;
using System.Text;
using System.Globalization;
class Program
{
    string[] ListPairs = [];
    List<string> ListOfInputs = [];
    List<int> List1Numbers = [];
    List<int> List2Numbers = [];
    int totalOccurances = 0;
    int totalDistance = 0;
    string ListPath = @"..\..\..\TextFile\LIST.txt";

    static void Main()
    {
        Program program = new Program();
        program.ReadList();

        Console.WriteLine(program.totalDistance);
    }

    void ReadList()
    {
        ListOfInputs = new List<string>(File.ReadAllLines(ListPath));

        for (int i = 0; i < ListOfInputs.Count; i++)
        {
            ListPairs = ListOfInputs[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);


            List1Numbers.Add(int.Parse(ListPairs[0]));

            List2Numbers.Add(int.Parse(ListPairs[1]));


        }
        List1Numbers.Sort();
        List2Numbers.Sort();
        CompareLists(List1Numbers, List2Numbers);

    }

    void CompareLists(List<int> list1, List<int> list2)
    {
        int listLength = list1.Count;

        for (int i = 0; i < listLength; i++)
        {
            for (int j = 0; j < listLength; j++)
            {
                if (list1[i] == list2[j])
                {
                    totalOccurances += 1;
                }
            }

            totalDistance += Math.Abs(list1[i] * totalOccurances);
            totalOccurances = 0;
        }

    }
}