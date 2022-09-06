namespace MyApp;

public class IsLeapYear{
    public Boolean isLeapYear(int year){

        if(year % 4 == 0 && (year%100 != 0 || year%400 == 0) && year >= 1582){
            return true;
        }
        
        return false;
    }
    
    
}
