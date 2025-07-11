public class A {
    public A() {
        Console.WriteLine("A");
    }

    public virtual void Func1() {
        Console.WriteLine($"Func1 in class A");
    }
}

public class B : A {
    public B() {
        Console.WriteLine("B");
    }

    public override void Func1() {
        Console.WriteLine("Func1 in class B");
    }
}

public class C {
    public C() {}

    public virtual void Func2() {}
}

public class D : C {
    public D() {}

    public override void Func2() {}
}

public class E : D {
    public E() {}

    public override void Func2() {}
}
