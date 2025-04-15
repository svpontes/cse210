public class Cycling : Activity{    
    
    private double _speed; // em km/h

    public Cycling(string date, int minutes, double speed) : base(date, minutes){

        _speed = speed;
    }

    public override double GetSpeed(){

        return _speed;
    }

    public override double GetDistance(){

        return (_speed * GetMinutes()) / 60.0;
    }

    public override double GetPace(){
        
        return GetMinutes() / GetDistance();
    }
}