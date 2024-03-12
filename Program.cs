
string[] arr = { "1345", "1575", "-2", "computer science", ":)" };

string str = ArrToStr(arr);

string[] arr2 = StrToArr(str);

PrintRes(arr2);


string ArrToStr(string[] arr)
{
    int flag = 0;
    int len = 0;
    string result = "";

    foreach (string e in arr)
    {
        len = e.Length;

        if (len <= 3)
        {
            if (flag == 0)
            {
                result = e;
            }
            else
            {
                result = result + ", " + e;
            }
            
            flag = 1;
        }
    }
    return (result);
}

string[] StrToArr(string str)
{
    string[] arr = str.Split(", ");
    return(arr);
}

void PrintRes(string[] arr)
{
    int flag = 0;
    string res = "[";

    if (arr.Length > 0)
    {
        foreach (string e in arr)
        {
            if (e != "")
            {
                if (flag == 0)
                {
                    res = res + "\"" + e + "\"";
                }
                else
                {
                    res = res + ", " + "\"" + e + "\"";
                }
                
                flag = 1;
            }
        }
    }
    res = res + "]";

    Console.WriteLine(res);
}