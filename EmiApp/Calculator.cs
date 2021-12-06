namespace EmiApp
{
    public class Calculator: ICalculator
    {
        
        public Response CalculateContinousEmi(Request request)
        {
            var response = new Response();
            try
            {
                var p = request.Principal;
                var t = request.LoanDurationInYearCount;
                var r = request.InterestRateInPercentage / 100;
                double e = 2.7183;
                var a = (double)p * Math.Pow(e, (r * t));
           
                response.EmiPayment = (decimal)a;
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            return response;
            throw new NotImplementedException();
        }

        public Response CalculateDailyEmi(Request request)
        {
            var response = new Response();
            try
            {
                var p = request.Principal;
                var t = request.LoanDurationInYearCount;
                var i = request.InterestRateInPercentage / 100;
                double e = 2.7183;
                var a = (double)p * Math.Pow(e, (i * t));
                response.EmiPayment = (decimal)a;
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            return response;
            throw new NotImplementedException();
        }

        public Response CalculateMonthlyEmi(Request request)
        {
            var response = new Response();
            try
            {
                var power = request.LoanDurationInYearCount * 12;
                var rate = request.InterestRateInPercentage / 100;
                var accumulated = (double)request.Principal * Math.Pow(1 + rate / 12, power);
              
                // convert to response object
                response.EmiPayment = (decimal)accumulated;
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            finally { }
            return response;
        }
    }
}