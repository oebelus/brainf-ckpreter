/*
input: +++++[-]

[0, 0, 0, 0, 0, 0, 0, ...]
    ^
[5, 0, 0, 0, 0, 0, 0, ...] Before the [ - ]
[0, 0, 0, 0, 0, 0, 0, ...] After the  [ - ]
*/
/*
string input = "+++++[-]";
int length = input.Length;
int memory = 0;
int value = 0;
int index = 0;
int i = 0;
while (i < length) {
    switch (input[i]) {
        case '+':
            value++;
            break;
        case '-':
            value--;
            break;
        case '>':
            memory++;
            break;
        case '<':
            memory--;
            break;
    }
    if (input[i] == '[') {
        index = i;
        if (input[i] == ']' && value == 0) break;
    }
    else if (input[i] == ']') {
        if (value == 0) break;
        else i = index;
    }
    i++;
}
Console.WriteLine(value);*/