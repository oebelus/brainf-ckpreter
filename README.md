# BrainF*ck Interpreter
![Hello, World!](https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/Hello_World_Brainfuck.png/280px-Hello_World_Brainfuck.png)

A simple Brainfuck interpreter that asks you to input your Brainfuck code in the console and to output the result.  
# Features
- It supports all the standard Brainfuck commands, including nested brackets (I can't help BUT mention this as I spent a long time ATTEMPTING TO IMPLEMENT THEM XD)
- It prints the output and also the tape after interpreting the code (The initial tape size is 1)
# How to use it?
Run the program, then it will ask you to enter your code: 
```
>> Write your BrainF*ck code here:
```
Let's attempt with `Hello, World!`: 
```
++++++++[>++++[>++>+++>+++>+<<<<-]>+>+>->>+[<]<-]>>.>---.+++++++..+++.>>.<-.<.+++.------.--------.>>+.>++.
```
It will output the following result and prompt you to write another code: 
```
>> Hello World!
>> Tape: [0][0][72][100][87][33][10]
>> Write your BrainF*ck code here:
```
You can exit the program in the same way you exit Vim - You can't -Just Kidding- -, type `:q!`; 
