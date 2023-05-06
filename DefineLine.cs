
namespace OOPsLineComputation
{
    public class DefineLine
    {
        public int x1,y1,x2,y2;
        public double area;
        public DefineLine(){
        }
        public DefineLine(int x1,int y1,int x2,int y2){
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.area=this.CalculateLength();
        }

        public double CalculateLength(){
            return Math.Sqrt(((this.x2-this.x1)*(this.x2-this.x1))+((this.y2-this.y1)*(this.y2-this.y1)));
        }


    }
}