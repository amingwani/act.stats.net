using DataStructures;

namespace Regression;

public class LinearRegression
{
    private double _intercept;
    private double _gradient;
    private Table _data;

    public LinearRegression(Table data)
    {
        _data = data;
    }

    public void fit(string Y, string[] X)
    {
    }

    public double predict(double X)
    {
        var y = _gradient * X + _intercept;
        return y;
    }
}