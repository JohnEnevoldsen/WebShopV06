using System;
// ReSharper disable UnusedVariable
#pragma warning disable 219

namespace WebShopV06
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            double netPriceBook = 30;
            double netPriceDVD = 50;
            double netPriceGame = 100;

            // int noOfBooksInOrder = 8;
            // int noOfDVDsInOrder = 3;
            // int noOfGamesInOrder = 2;

            // int noOfBooksInOrder = 0;
            // int noOfDVDsInOrder = 12;
            // int noOfGamesInOrder = 4;

            // int noOfBooksInOrder = 23;
            // int noOfDVDsInOrder = 16;
            // int noOfGamesInOrder = 7;

            int noOfBooksInOrder = 3;
            int noOfDVDsInOrder = 5;
            int noOfGamesInOrder = 4;

            double totalNetPrice = netPriceBook * noOfBooksInOrder + netPriceDVD * noOfDVDsInOrder + netPriceGame * noOfGamesInOrder;

            // SO#1
            bool receiveSpecialOffer1 = false;

            // SO#2
            bool receiveSpecialOffer2 = false;

            // SO#3
            bool receiveSpecialOffer3 = false;

            // SO#4
            bool receiveSpecialOffer4 = false;

            int numberOfSO = 0;

            if(totalNetPrice > 1000){
                receiveSpecialOffer1 = true;
                numberOfSO++;
            }
            if(noOfBooksInOrder > noOfGamesInOrder){
                receiveSpecialOffer2 = true;
                numberOfSO++;
            }
            if(noOfBooksInOrder >= 10 || noOfDVDsInOrder >= 10 || noOfGamesInOrder >= 10){
                receiveSpecialOffer3 = true;
                numberOfSO++;
            }
            if(10 <= noOfDVDsInOrder && noOfDVDsInOrder <= 20 || noOfGamesInOrder >= 5){
                receiveSpecialOffer4 = true;
                numberOfSO++;
            }

            bool receiveSpecialOffer5 = numberOfSO == 2;

            Console.WriteLine($"You ordered {noOfBooksInOrder} books, {noOfDVDsInOrder} DVDs and {noOfGamesInOrder} games");
            Console.WriteLine($"You qualify for special offer #1 : {receiveSpecialOffer1}");
            Console.WriteLine($"You qualify for special offer #2 : {receiveSpecialOffer2}");
            Console.WriteLine($"You qualify for special offer #3 : {receiveSpecialOffer3}");
            Console.WriteLine($"You qualify for special offer #4 : {receiveSpecialOffer4}");
            Console.WriteLine($"You qualify for special extra offer : {receiveSpecialOffer5}");

            // The LAST line of code should be ABOVE this line
        }
    }
}