public class Pow_x__n_
{
    public double MyPow(double x, int n)
    {
        if (n == 0) return 1;
        if (n < 0) x = 1.0 / x;
        double ret = 1;
        while (n / 2 != 0)
        {
            if ((n & 1) == 1)
                ret *= x;
            x *= x;
            n /= 2;
        }
        return ret * x;
    }

    public double MyPow1(double x, int n)
    {
        if (n == 0) return 1;
        double ret = 1;
        while (n / 2 != 0)
        {
            if ((n & 1) == 1)
                ret *= n < 0 ? 1.0 / x : x;
            x *= x;
            n /= 2;
        }
        return ret *= n < 0 ? 1.0 / x : x;
    }

    public double MyPow2(double x, int n)
    {
        if (x == 0) return 0;
        if (n == 0) return 1;

        double r = MyPow(x, n / 2);
        r *= r;
        if ((n & 1) == 1)
            r *= (n < 0 ? 1.0 / x : x);
        return r;
    }
}