using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfStockPrices = int.Parse(Console.ReadLine());
        double significateStep = double.Parse(Console.ReadLine());
        double firstPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfStockPrices - 1; i++)
        {
            double otherPrices = double.Parse(Console.ReadLine());
            double diff = GetDifference(firstPrice, otherPrices);
            bool isSignificantDifference = CheckSignificance(diff, significateStep);
            string message = GetPriceEvaluation(otherPrices, firstPrice, diff, isSignificantDifference);
            Console.WriteLine(message);
            firstPrice = otherPrices;
        }
    }

    private static string GetPriceEvaluation(double otherPrices, double firstPrice, double diff, bool signDiff)
    {
        string messageText = "";
        if (diff == 0)
        {
            messageText = string.Format("NO CHANGE: {0}", otherPrices);
        }
        else if (!signDiff)
        {
            messageText = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", firstPrice, otherPrices, diff*100);
        }
        else if (signDiff && (diff > 0))
        {
            messageText = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", firstPrice, otherPrices, diff*100);
        }
        else if (signDiff && (diff < 0))
            messageText = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", firstPrice, otherPrices, diff*100);
        return messageText;
    }

    private static bool CheckSignificance(double diff, double significateStep)
    {
        if (Math.Abs(diff) >= significateStep)
        {
            return true;
        }
        return false;
    }

    private static double GetDifference(double firstPrice, double otherPrice)
    {
        double result = (otherPrice - firstPrice) / firstPrice;
        return result;
    }
}
