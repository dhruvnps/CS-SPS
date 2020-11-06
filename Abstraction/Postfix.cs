using System;

class Postfix
{
    static public float Evaluate(string s)
    {
        string[] equation = s.Split(' ');
        Stack<float> stack = new Stack<float>();
        foreach (var item in equation)
        {
            float num;
            if (!float.TryParse(item, out num))
            {
                num = Calculate(stack.Pop(), stack.Pop(), item);
            }
            stack.Push(num);
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
}