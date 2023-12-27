// 2 var
public class MyClass
{
    public int day;
    public int year;
    public int month;

    public int Day
    {
        get { return day; }
        set
        {
            if (value >= 0) day = value;
            else day = 0;
        }
    }
    public int Mounth
    {
        get { return month; }
        set
        {
            if (value >= 0) month = value;
            else month = 0;
        }
    }
    public int Year
    {
        get { return year; }
        set
        {
            if (value >= 0) year = value;
            else year = 0;
        }
    }
    public MyClass(int day, int month, int year)
    {
        Day = day;
        Mounth = month;
        Year = year;
    }

    public MyClass()
    {
        Day = 0;
        Mounth = 0;
        Year = 0;
    }
    public void AddYear()
    {
        Year += 1;
    }

    public void SubRwoDays()
    {
        DateTime date = new DateTime(Year, Mounth, Day);
        date.Subtract(new TimeSpan(2));
        Day = date.Day;
        Mounth = date.Month;
        Year = date.Year;
    }
}