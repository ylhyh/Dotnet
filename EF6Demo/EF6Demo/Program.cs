using System;
using System.IO;
using System.Linq;
using EF6Demo.CodeFirst.Entities;

namespace EF6Demo.CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //http://blogs.msdn.com/b/dataaccess/archive/2005/10/28/486273.aspx
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data"));

            using (var db = new DemoDbContext())
            {
                if (!db.Database.Exists())
                {
                    var group = new Group
                    {
                        GroupName = "管理员组"
                    };

                    var user = new User
                    {
                        UserId = "ylhyh",
                        Password = "123456",
                        Nickname = "Alan Hu",
                        Email = "ylhuyh@163.com",
                        MobilePhone = "13926581626",
                        UserGroup = group
                    };

                    /*
                     * Make sure the folder exists of the data file, otherwise, the Add method will not create db automatically and throw error below:
                     * 其他信息: Directory lookup for the file "E:\TestPrj\Dotnet\EF6Demo\EF6Demo\bin\Debug\App_Data\VDatabase.mdf" failed with the operating system error 2(系统找不到指定的文件。).
                     * CREATE DATABASE failed. Some file names listed could not be created. Check related errors.
                     */
                    db.Set<Group>().Add(group);
                    db.Set<User>().Add(user);
                    //db.Groups.Add(group);
                    //db.Users.Add(user);

                    var recordCount = db.SaveChanges();
                }
                else
                {
                    var users = from u in db.Users orderby u.Id select u;

                    foreach (var user in users)
                    {
                        Console.WriteLine(user.Nickname);
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
