namespace Week1;

public class Calculator
{
    
    
    public float Sum(float num1, float num2)
    {
        return num1 + num2;
    }
    
    public float Sub(float num1, float num2)
    {
        return num1 - num2;
    }
    
    public float Mul(float num1, float num2)
    {
        return num1 * num2;
    }
    
    public float Div(float num1, float num2)
    {
        if (num1 == 0 || num2 == 0)
        {
            throw new DivideByZeroException();
        }
        return num1 / num2;
    }
    
    
}