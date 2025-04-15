public abstract class Activity{
    private string _date;
    private int _minutes;

    // Constructor
    public Activity(string date, int minutes){

        _date = date;
        _minutes = minutes;
    }

    // Getters
    public string GetDate(){

        return _date;
    }

    public int GetMinutes(){

        return _minutes;
    }

    // Setter
    public void SetDate(string date){

        _date = date;
    }

    // Métodos abstratos
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Método virtual
    public virtual string GetSummary(){
        
        return $"{_date} {this.GetType().Name} ({_minutes} min): " +
               $"Distance: {GetDistance():0.0} km, " +
               $"Speed: {GetSpeed():0.0} kph, " +
               $"Pace: {GetPace():0.00} min per km";
    }
}