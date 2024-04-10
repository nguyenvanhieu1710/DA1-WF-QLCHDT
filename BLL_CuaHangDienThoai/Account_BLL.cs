using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DAL_CuaHangDienThoai;
using DTO_CuaHangDienThoai;

namespace BLL_CuaHangDienThoai
{
    public class Account_BLL
    {
        Account_DAL account_DAL = new Account_DAL();
        public bool CheckAccount(Account_DTO account_DTO)
        {
            List<Account_DTO> accountList = account_DAL.AccoutList();
            foreach (Account_DTO account in accountList)
            {
                if(account.AccoutName == account_DTO.AccoutName && account.Password == account_DTO.Password && account.Role == account_DTO.Role)
                { 
                    return true;
                } 
            }
            return false;
        }
        public bool CheckExited(string AccountName)
        {
            List<Account_DTO> accountList = account_DAL.AccoutList();
            foreach(Account_DTO account in accountList)
            {
                if(account.AccoutName == AccountName)
                {
                    return true;
                }
            }
            return false;
        }
        public void insertAccountCustomer_BLL(string UserName, string Password, string Email)
        {
            Account_DAL account_DAL = new Account_DAL();
            account_DAL.insertAccountCustomer_DAL(UserName, Password, Email);
        }
        public int SendCode(string email)
        {
            Random random = new Random();
            int code = random.Next(100000, 999999);
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(email);
            mailMessage.From = new MailAddress("hieunghiendo1@gmail.com");
            mailMessage.Subject = "Verification Code";
            mailMessage.Body = code.ToString();
            mailMessage.Priority = MailPriority.High;


            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential("hieunghiendo1@gmail.com", "ufag xhnw rgqx phvu");
            try
            {
                smtpClient.Send(mailMessage);
                return code;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
