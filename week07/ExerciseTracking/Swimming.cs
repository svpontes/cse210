public class Swimming : Activity{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes){

        _laps = laps;
    }

    public override double GetDistance(){

        return (_laps * 50.0) / 1000; // metros para km
    }

    public override double GetSpeed(){

        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace(){
        
        return GetMinutes() / GetDistance();
    }
}