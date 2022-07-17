namespace CSharp.Features._7._0
{
    class ExpressionBodiedMembers
    {
        private int i;

        public ExpressionBodiedMembers(int i) => this.i = i;
        ~ExpressionBodiedMembers() => this.i = 0;

        public int I
        {
            get => this.i;
            set => this.i = value;
        }
    }
}
