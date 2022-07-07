namespace CSharp.Features._6._0
{
    class ExceptionFiltering
    {
        public void Run()
        {
            Random random = new Random();
            var randomExceptions = random.Next(400, 405);

            try
            {
                throw new Exception(randomExceptions.ToString());
            }
            catch (Exception ex) when (ex.Message.Equals("400"))
            {
                Console.WriteLine("Bad Request");
            }
            catch (Exception ex) when (ex.Message.Equals("401"))
            {
                Console.WriteLine("Unauthorized");
            }
            catch (Exception ex) when (ex.Message.Equals("402"))
            {
                Console.Write("Payment Required");
            }
            catch (Exception ex) when (ex.Message.Equals("403"))
            {
                Console.Write("Forbidden");
            }
            catch (Exception ex) when (ex.Message.Equals("404"))
            {
                Console.Write("Not Found");
            }
        }
    }
}
