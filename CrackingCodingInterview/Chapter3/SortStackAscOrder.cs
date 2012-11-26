using System;
using System.Collections.Generic;

namespace CrackingCodingInterview.Chapter3
{
    [Reference(
        Page = 52
        , Number = "3.6"
        , Description = "Write a program to sort a stack in ascending order. " +
                        "You should not make any assumptions about how the stack is implemented." +
                        "The following are the only functions that should be used to write" +
                        "this program: push|pop|peek|isEmpty")]
    public class SortStackAscOrder : Algorithm<Stack<int>, Stack<int>>
    {
        protected override int? OnInitComplexity(Stack<int> arg)
        {
            if (arg == null) throw new ArgumentNullException("arg");
            return arg.Count;
        }
        
        protected override Stack<int> OnExecute(Stack<int> arg)
        {
            if (arg == null) throw new ArgumentNullException("arg");

            var stack = new Stack<int>(arg);
            arg.Clear();

            while (stack.Count > 0)
            {
                IncrementIteration();

                var tmp = stack.Pop();

                while ((arg.Count > 0) && (arg.Peek() > tmp))
                {
                    IncrementIteration();
                    stack.Push(arg.Pop());
                }

                arg.Push(tmp);
            }

            return arg;
        }
    }
}
