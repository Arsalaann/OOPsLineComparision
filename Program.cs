namespace OOPsLineComputation
{
    public class Program
    {
        private int X1=2,X2=4,Y1=6,Y2=8,x1=1,y1=3,x2=5,y2=7; 
        public static void Main(string[] args){
            Program obj=new Program();
            DefineLine line1=new DefineLine(obj.X1,obj.Y1,obj.X2,obj.Y2);
            DefineLine line2=new DefineLine(obj.x1,obj.y1,obj.x2,obj.y2);
            int status=line1.area.CompareTo(line2.area);
            if(status==0)
                Console.WriteLine("Lines are Equal");
            else if(status>1)
                Console.WriteLine("Line1 is greater than Line2 by "+(line1.area-line2.area)+" Length");
            else
                Console.WriteLine("Line2 is greater than Line1 by "+(line2.area-line1.area)+" Length");
        }
    }
}