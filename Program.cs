/* Successful tests:
    +++++[-] : 0
    >>>>++ : 0002
    >+++++++++[<++++++++>-]< : 720000000000
    >>>>++<<+>>+ : 010300
/*

/* Whiteboarding 
    [0, 0, 0, 0, 0, 0, 0, ...]
     ^
    [5, 0, 0, 0, 0, 0, 0, ...] Before the [ - ]
    [0, 0, 0, 0, 0, 0, 0, ...] After the  [ - ]
*/

string input = "++++++++[>++++++++<-]>++++++++.>++++++++[>++++++++++++<-]>+++++.+++++++..+++.>++++++++[>+++++<-]>++++.------------.<<<<+++++++++++++++.>>.+++.------.--------.>>+.";
List<int> output = [0];
int length = input.Length;
int olength = output.Count;
int memory = 0;
int index = 0;
int count = 0;
int right = 0;
int i = 0;
while (i < length) {
    switch (input[i]) {
        case '+':
            output[memory]++;
            break;
        case '-':
            output[memory]--;
            break;
        case '>':
            output.Add(0);
            memory++;
            break;
        case '<':
            memory--;
            break;
        case '.':
            char asc = (char)output[memory];
            Console.Write(asc);
            break;
        case '[':
            count++;
            index = i;
            if (input[i] == ']' && output[memory] == 0) i = right;
            break;
        case ']':
            right = i;
            if (output[memory] == 0) i = right;
            else i = index;
            break;
    }
    i++;
}

//if (count == 0) output.RemoveAt(0);
/*Console.WriteLine();
Console.WriteLine($"Memory: {memory} Count: {length}");*/

