//Делегаты
/*Calculator calculator = new Calculator();
Console.WriteLine("Enter an expression: ");
string expression=Console.ReadLine();
char sign = ' ';
foreach(char item in expression)
{
    if(item=='+'||item=='-'||item=='*'||item=='/')
    {
        sign = item; 
        break; 
    }
}
try
{
    string[] numbers = expression.Split(sign);
    CalcDelegate del = null;
    switch(sign)
    {
        case '+':
            del = new CalcDelegate(calculator.Add);
            break;
        case '-':
            del = new CalcDelegate(Calculator.Sub);
            break;
        case '*':
            del = calculator.Mul;
            break;
        case '/':
            del = calculator.Div;
            break;
        default:
            throw new InvalidOperationException();
    }
    Console.WriteLine($"Result: {del(double.Parse(numbers[0]), double.Parse(numbers[1]))}");
}catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
public delegate double CalcDelegate(double x, double y);
public class Calculator
{
    public double Add(double x, double y)
    { return x + y; }
    public static double Sub(double x,double y) { return x - y; }
    public double Mul(double x,double y) { return x * y; }
    public double Div(double x,double y) 
    {
        if(y !=0)
            return x / y; 
        throw new DivideByZeroException();
    }
}*/
/*Operation operation = Add;
int result = operation(6, 9);
Console.WriteLine(result);

operation = Mult;
result = operation(7, 10);
Console.WriteLine(result);

Message message = Hello;
message += HowAreYou;
message();

DoOperation(5, 6, Add);
DoOperation(7, 8, Mult);

Operation SelectOperation(OperationType opType)
{
    switch (opType)
    {
        case OperationType.Add: return Add;
        case OperationType.Substract:return Substract;
        default:return Mult;
    }
}
int Add(int x, int y)=>x+y;
int Substract(int x, int y) => x - y;
int Mult(int x, int y)=>x*y;
void DoOperation(int a, int b, Operation op)
{
    Console.WriteLine(op(a, b));
}
void Hello() => Console.WriteLine("Hello");
void HowAreYou() => Console.WriteLine("How are you?");

enum OperationType
{
    Add,Substract,Multiply
}
delegate int Operation(int x, int y);
delegate void Message();*/
/*Account account = new Account(150);
account.RegisterHandler(PrintSimpleMessage);
account.RegisterHandler(PrintColorMessage);
account.Take(100);
account.Take(75);
account.Unregisterhandler(PrintColorMessage);
account.Take(75);

void PrintSimpleMessage(string message)=>Console.WriteLine(message);
void PrintColorMessage(string message)
{
    Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine(message);
    Console.ResetColor();
}
public delegate void AccountHandler(string message);
public class Account
{
    int sum;
    AccountHandler? taken;
    public Account(int sum)=>this.sum=sum;
    public void RegisterHandler(AccountHandler handler)
    {
        taken+=handler;
    }
    public void Unregisterhandler(AccountHandler handler)
    {
        taken -= handler;
    }
    public void Add(int sum)=>this.sum+=sum;
    public void Take(int sum)
    {
        if(this.sum >= sum)
        {
            this.sum -= sum;
            //Console.WriteLine($"Со счета списано {sum} у.е.");
            taken?.Invoke($"Со счета списано {sum} у.е.");
        }
        else
        {
            taken?.Invoke($"Недостаточно средств. Баланс: {this.sum} y.e.");
        }
    }
}*/
/*MessageHandler handler = delegate (string mes)
{
    Console.WriteLine(mes);
};
handler("Hello world!");

delegate void MessageHandler(string message);*/
Message hello=()=>Console.WriteLine("hello");
hello();

delegate void Message();