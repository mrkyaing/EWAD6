namespace OOPDay1
{
    public class Car
    {
        //states
        public string Model;
        public string Color;
        public string Gearno;
        public string LicenceNo;
        
        public Car(){

        }
        //behaviors
        public void StartEngine()=>Console.WriteLine("Engine Started");

        public void StopEngine()=>Console.WriteLine("Engine Stopped");
        //Method Overloading
        public void PlayHorn(int count){
            for(int i=0; i<count; i++){
                Console.WriteLine("T");
            }
        }
        //Method Overloading >>one of polymprphism
        public void PlayHorn()=>Console.WriteLine("T");

        override public string ToString(){
            return $"Model: {Model}, Color: {Color}, Gearno: {Gearno}, LicenceNo: {LicenceNo}";
        }

        public static void UseBreak()=>Console.WriteLine("Break Used");
    }
}