using System;

class Postfix
{
    static public float Evaluate(string postfix)
    {
        string[] equation = postfix.Split(' ');
        Stack<float> stack = new Stack<float>();
        foreach (var item in equation)
        {
            if (!float.TryParse(item, out float value))
            {
                value = Calculate(stack.Pop(), stack.Pop(), item);
            }
            stack.Push(value);
        }
        return stack.Pop();
    }

    static float Calculate(float num1, float num2, string s)
    {
        switch (s)
        {
            case "+":
                return num2 + num1;
            case "-":
                return num2 - num1;
            case "*":
                return num2 * num1;
            case "/":
                return num2 / num1;
        }
        return 0;
    }

    static public string GetInfix(string postfix)
    {
        string[] equation = postfix.Split(' ');
        Stack<string> stack = new Stack<string>();
        foreach (var item in equation)
        {
            if (float.TryParse(item, out var _))
            {
                stack.Push(item);
                continue;
            }
            var nums = (stack.Pop(), stack.Pop());
            stack.Push($"({nums.Item2} {item} {nums.Item1})");
        }
        return stack.Pop();
    }
}