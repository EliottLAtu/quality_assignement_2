using System;

// creation of the service normalement je suis dans le bon
public interface IDiscountService
{
    double GetDiscount();
}

public class ParkingService
{
    private readonly IDiscountService discountService;

    public ParkingService(IDiscountService discountService)
    {
        this.discountService = discountService;
    }

    public double CalculateFee(int hours, string vehicleType)
    {
        double fee = 0 ;

        if (vehicleType == "standard")
            if ((hours >= 1) && (hours <= 3))
                fee = hours * 4.0;
            else if (hours >= 4)
                fee = hours * 3.0;
            else
                fee = 0.0;
        else if (vehicleType == "electric")
            if ((hours >= 1) && (hours <= 5))
                fee = hours * 3.0;
            else if (hours >= 6)
                fee = hours * 2.0;
            else
                fee = 0.0;
        

        double discount = discountService.GetDiscount();

        if (hours >= 10)
            fee = fee * discount;

        return fee;
    }
    
}
