

namespace Overloading_
{
    class struct Complex
    {
        public int real;
        public int imaginary;

    }
    public Complex(int real,int imaginary) //constructor
    {
        this.real = real;
        this.imaginary = imaginary;

    }
    //Declare which operator to overload (+),
    //the types that can be added (two Complex object)
    //and the return type (complex):
    public static Complex operator +(Complex c1,Complex c2)
    {
        return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
    }
    //Override the toString() method to display a complex number in the traditional format:
    public override string toSrring()
    {
        return (System.String.Format("{0}+{1}i", real.imaginary));

    }

}
