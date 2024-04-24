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
        public List<Account_DTO> accountList()
        {
            List<Account_DTO> accountList = account_DAL.AccoutList();
            return accountList;
        }
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
        public (int, Account_DTO) checkAndGetAccountOnline()
        {
            List<Account_DTO> accountList = account_DAL.AccoutList();
            int quantityAccountOnline = 0;
            Account_DTO accountOnline = null;
            foreach (Account_DTO account in accountList)
            {
                if (account.Status == "Online")
                {
                    quantityAccountOnline++;
                    accountOnline = account;
                }
            }
            return (quantityAccountOnline, accountOnline);
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
        public int updatePassword(string customerName, string newPassword)
        {          
            List<Account_DTO> accountList = account_DAL.AccoutList();
            foreach (Account_DTO account in accountList)
            {
                if (account.AccoutName == customerName)
                {
                    int result = account_DAL.updatePassword(account, newPassword);
                    return result;
                }
            }
            return 0;
        }
        public void updateStatusOnline(Account_DTO account_DTO)
        {
            List<Account_DTO> accounts = accountList();
            foreach (Account_DTO account in accounts)
            {
                if (account.AccoutName == account_DTO.AccoutName)
                {
                    account_DAL.updateStatusOnline(account);
                }
            }
        }
        public void updateStatusOffline(Account_DTO account_DTO)
        {
            List<Account_DTO> accounts = accountList();
            foreach (Account_DTO account in accounts)
            {
                if (account.AccoutName == account_DTO.AccoutName)
                {
                    account_DAL.updateStatusOffline(account);
                }
            }
        }
        public void UpdateStatusOffline()
        {
            List<Account_DTO> accounts = accountList();
            foreach (Account_DTO account in accounts)
            {
                if (account.Status == "Online")
                {
                    account_DAL.updateStatusOffline(account);
                }
            }
        }
    }
}
