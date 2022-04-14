using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSupply
{
   public class TestClass
    {
        public static bool Authorization(string Login, string Password)
        {
            User EnterUser = DataBase.a.User.Where(l => l.login == Login && l.password == Password).FirstOrDefault();
            if (EnterUser != null)
            {
                return true;
            }
            else return false;
        }

        public static bool AddContract(int ContractNumber, string SignaturDate, decimal Payent, string FinishDate, int IndicatorNumber, int VolumeNumber, int CodeEmployee, int SubscribersTIN)
        {
            try
            {
                Contract contract = new Contract();
                contract.Contract_number = Convert.ToInt32(ContractNumber);
                contract.Signature_date = Convert.ToDateTime(SignaturDate);
                contract.Payment = Convert.ToDecimal(Payent);
                contract.Finish_Date = Convert.ToDateTime(FinishDate);
                contract.Indicator_number = Convert.ToInt32(IndicatorNumber);
                contract.Volume_number = Convert.ToInt32(VolumeNumber);
                contract.Code_Employee = Convert.ToInt32(CodeEmployee);
                contract.Subscribers_TIN = Convert.ToInt32(SubscribersTIN);
                return true;
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        public static bool AddSubcriber(string SubscribersTIN, string NameOrganization, string CheckingAccount, string DirectoR, string AddresS, string NumbeR, int CorrespondentAccount)
        {
            try
            {
                Subscriber subscriber = new Subscriber();
                subscriber.Subscribers_TIN = Convert.ToInt32(SubscribersTIN);
                subscriber.Name_organization = NameOrganization;
                subscriber.Checking_account = CheckingAccount;
                subscriber.Director = DirectoR;
                subscriber.Address = AddresS;
                subscriber.Number = NumbeR;
                subscriber.Correspondent_account = Convert.ToInt32(CorrespondentAccount);
                return true;
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        public static bool AddPlace(string PlaceExecution, string TitlE, string AddresS, int SubscribersTIN)
        {
            try
            {
                Place_execution place = new Place_execution();
                place.Place_execution_number = Convert.ToInt32(PlaceExecution);
                place.Title = TitlE;
                place.Address = AddresS;
                place.Subscribers_TIN = SubscribersTIN;
                return true;
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        public static bool SortPlaceObj()
        {   
                return true;
        }

        public static bool SortPlaceName()
        {
                return true;  
        }
    }
}
