using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 命令栈
// 命令模式：将来自UI组件的命令封装为命令对象，存入命令栈中
// 单例模式
public class CommandStack
{
    private static CommandStack _instance = new CommandStack();
    private CommandStack() { }
    public static CommandStack getInstance()
    {
        return _instance;
    }

    private Stack<Command> _commands = new Stack<Command>();
    public void Push(Command command)
    {
        _commands.Push(command);
    }
    public Command Pop()
    {
        return _commands.Pop();
    }
}
