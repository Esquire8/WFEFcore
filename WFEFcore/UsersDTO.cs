using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WFEFcore
{
    internal class UsersDTO : IDisposable
    {
        //Получаем список пользователей
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (var context = new ApplicationContext())
            {
                users = context.users.ToList();
            }
            return users;
        }

        //Создаем нового пользователя
        public void CreateNewUser(string login, string password) 
        {
            User user = new User();
            List<User> allUsers = new List<User>();

            user.user_login = login;
            user.user_password = password;

            using(var context = new ApplicationContext())
            {
                allUsers = context.users.ToList();

                if (allUsers.Where(l => l.user_login == login).FirstOrDefault() != null)
                {
                    MessageBox.Show("Такой пользователь существует!");
                }
                else
                {
                    try
                    {
                        context.users.Add(user);
                        context.SaveChanges();
                        MessageBox.Show("Пользователь успешно добавлен!");
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public void Dispose()
        {
            // throw new NotImplementedException();
        }
    }
}
