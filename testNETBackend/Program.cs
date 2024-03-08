//var sale = new SaleWithTax(15, 1.16m);
//sale.Total = 15;

//var message = sale.GetInfo();

//Console.WriteLine(message);

//class SaleWithTax : Sale
//{
//    public decimal Tax {  get; set; }   
//    public SaleWithTax(decimal total, decimal tax) : base(total)
//    {
//        this.Tax = tax;
//    }

//    public override string GetInfo()
//    {
//        return "El total es de " + Total + " más impuestos: " + Tax;
//    }

//    public string GetInfo(string message)
//    {
//        return message;
//    }

//    public string GetInf(int a)
//    {
//        return a.ToString();
//    }
//}

//class Sale
//{
//    public decimal Total { get; set;}

//    public Sale(decimal total) 
//    {
//        this.Total = total;
//    }

//    public virtual string GetInfo()
//    {
//        return "El total es " + Total;
//    }

//}

///////////////////////////




//var sale = new Sale();
//var beer = new Beer();

//Some(sale);
//Some(beer);

//void Some(ISave save)
//{
//    save.Save();
//}

//interface ISale
//{
//    decimal Total { get; set; }  
//}

//interface ISave
//{
//    public void Save();
//}

//public class Sale : ISale, ISave
//{
//    public decimal Total { get; set; } 
//    public void Save()
//    {
//        Console.WriteLine("Se guardo en BD");
//    }
//}

//public class Beer : ISave
//{
//    public void Save()
//    {
//        Console.WriteLine("Se guardo en Servicio");    
//    }
//}


/////////////////////////////
///

var numbers = new MyList<int>(5); 
var names = new MyList<string>(4);

numbers.Add(1);
numbers.Add(2);
numbers.Add(3); 
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);

names.Add("Catalina");
names.Add("Belen");
names.Add("Roberto");
names.Add("Juan");
names.Add("Patricio");

Console.WriteLine(numbers.GetContent());
Console.WriteLine(names.GetContent());

public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit) {
        this._limit = limit;
        _list = new List<T>();
    }

    public void Add(T element)
    {
        if(_list.Count < _limit)
        {
            _list.Add(element);
        }
    }

    public string GetContent()
    {
        string content = "";

        foreach (var element in _list)
        {
            content += element + ", ";
        }

        return content;
    }
}

