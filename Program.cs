/* Successful tests:
    +++++[-] : 0
    >>>>++ : 0002
    >+++++++++[<++++++++>-]< : 720000000000
    >>>>++<<+>>+ : 010300
    ,[.,] : cat 
/*

/* Whiteboarding 
    [0, 0, 0, 0, 0, 0, 0, ...]
     ^
    [5, 0, 0, 0, 0, 0, 0, ...] Before the [ - ]
    [0, 0, 0, 0, 0, 0, 0, ...] After the  [ - ]
*/

string? input = "";
while (input != ":q!") {
    Console.WriteLine("Write your BrainF*ck code here:");
    input = Console.ReadLine();
    int length = input?.Length??0;
    Dictionary <int, int> brackets = [];
    Stack <int> stack = [];

    int j = 0;
    while (j < length) {
        if (input?[j] == '[') stack.Push(j);
        if (input?[j] == ']') {
            int start = stack.Pop();
            brackets[start] = j;
            brackets[j] = start;
        }
        j++;
    }

    List<int> output = [0];
    int memory = 0;
    bool hasBracket = false;
    int i = 0;
    while (i < length) {
        switch (input?[i]) {
            case '+':
                output[memory]++;
                break;
            case '-':
                if (output[memory] > 0) output[memory]--;
                break;
            case '>':
                if (memory == output.Count - 1) output.Add(0);
                memory++;
                break;
            case '<':
                if (memory > 0) memory--;
                break;
            case '.':
                char asc = (char)output[memory];
                Console.Write(asc);
                break;
            case ',':
                output[memory] = Convert.ToInt32(Console.ReadLine());
                break;
            case '[':
                hasBracket = true;
                if (output[memory] == 0) i = brackets[i];
                break;
            case ']':
                if (output[memory] != 0) i = brackets[i];
                break;
            }
        i++;
    }

    if (hasBracket == false && (input?[0] == '>' || input?[0] == '<')) output.RemoveAt(0);
    Console.Write("Tape: "); foreach (int el in output) Console.Write($"[{el}]");
    Console.WriteLine();
}
