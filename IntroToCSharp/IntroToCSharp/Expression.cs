using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    // Interface = kontrakt - ingen implementeringer
    public interface IExpression
    {
        double Evaluate();
    }

    // Abtract class - underklasser er ansvarlig for implementering
    public abstract class Expression : IExpression
    {
        public abstract double Evaluate();
    }

    // Lukket klasse (her underklasse af Expression) - nedarving ikke muligt
    public sealed class ConstantExpression : Expression
    {
        private readonly double value;

        public ConstantExpression (double value)
        {
            this.value = value;
        }

        public override double Evaluate()
        {
            return this.value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }

    // Extension method to Expression class:
    public static class ExpressionExtensions
    {
        public static ConstantExpression ToExpression(this double value)
        {
            return new ConstantExpression(value);
        }
    }

    abstract class BinaryExpression : Expression
    {
        protected Expression left;
        protected Expression right;

        public abstract string OperatorSymbol
        {
            get;
        }

        public sealed override string ToString()
        {
            string str = "(" + this.left.ToString() + " " + this.OperatorSymbol + " " + this.right.ToString() + ")";
            return str.ToString();
        }
    }

    class PlusExpression : BinaryExpression
    {
        public PlusExpression(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }

        public override string OperatorSymbol
        {
            get
            {
                return "+";
            }            
        }

        public override double Evaluate()
        {
            return this.left.Evaluate() + this.right.Evaluate();
        }
    }

    class MinusExpression : BinaryExpression
    {
        public MinusExpression(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }

        public override string OperatorSymbol
        {
            get
            {
                return "-";
            }
        }

        public override double Evaluate()
        {
            return this.left.Evaluate() - this.right.Evaluate();
        }
    }

    class MultiplyExpression : BinaryExpression
    {
        public MultiplyExpression(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }

        public override string OperatorSymbol
        {
            get
            {
                return "*";
            }
        }

        public override double Evaluate()
        {
            return this.left.Evaluate() * this.right.Evaluate();
        }
    }

    class DivideExpression : BinaryExpression
    {
        public DivideExpression(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }

        public override string OperatorSymbol
        {
            get
            {
                return "/";
            }
        }

        public override double Evaluate()
        {
            return this.left.Evaluate() / this.right.Evaluate();
        }
    }

    class PowExpression : BinaryExpression
    {
        public PowExpression(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }

        public override string OperatorSymbol
        {
            get
            {
                return "^";
            }
        }

        public override double Evaluate()
        {
            return Math.Pow(this.left.Evaluate(), this.right.Evaluate());
        }
    }

    abstract class UnaryExpression : Expression
    {
        protected Expression expr;
    }

    class NegateExpression : UnaryExpression
    {
        public NegateExpression(Expression expr)
        {
            this.expr = expr;
        }

        public override double Evaluate()
        {
            return this.expr.Evaluate() * -1;
        }

        public override string ToString()
        {
            return this.Evaluate().ToString();
        }
    }

    class SquareExpression : UnaryExpression
    {
        public SquareExpression(Expression expr)
        {
            this.expr = expr;
        }

        public override double Evaluate()
        {
            return Math.Pow(this.expr.Evaluate(), 2);
            //return this.expr.Evaluate() * this.expr.Evaluate();
        }

        public override string ToString()
        {
            return this.expr.Evaluate().ToString() + " ^ 2";
        }
    }
}
