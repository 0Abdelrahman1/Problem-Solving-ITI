public class PO
{
    int[] a = [1,2,3];

    public int ID { get; init; } = 10;
    public PO()
    {
        ID = 10;
    }
    public ref int this[int i]
    {
        get => ref a[i]; 
    }

    public static implicit operator bool(PO x) => x.ID != 0;
}

public class C0 { public virtual void DS() => Console.WriteLine("C0");  }
public class C1 : C0 { public new virtual void DS() => Console.WriteLine("C1");  }
public class C2 : C1 { public new void DS() => Console.WriteLine("C2");  }

public class Program
{
    static void Main(string[] args)
    {
        C0 c00 = new C0(); c00.DS();
        C0 c01 = new C1(); c01.DS();
        C0 c02 = new C2(); c02.DS();

        //C1 c10 = new C0(); c10.DS();
        C1 c11 = new C1(); c11.DS();
        C1 c12 = new C2(); c12.DS();
        //C2 c20 = new C0(); c20.DS();
        //C2 c21 = new C1(); c21.DS();
        C2 c22 = new C2(); c22.DS();

    }
}
