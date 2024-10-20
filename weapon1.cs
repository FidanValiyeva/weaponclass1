using System.Reflection;
using System.Runtime.InteropServices.JavaScript;
using System;

namespace ConsoleApp6
{
    internal class Program
    {
        //        Weapon deyə class yaradılır.
        //Darağın güllə tutumu, Daraqdakı güllə sayı,atış modu(təkli və ya avtomatik) propertileri verilir.
        //Shoot() -  metodu hər çağırıldıqda fire moduna gore ya 1 güllə atır yada avtomatik gulleni bosaldir.(Ekranda bunu bildirir)
        //GetRemainBulletCount() - darağın tam dolması üçün lazım olan güllə sayını qaytarır.
        //Reload() - darağı yenidən doldurur.
        //ChangeFireMode() - Atış modunu dəyişir.
       //Bütün məlumatları doldurmadan obyekt yaratmaq olmasın.,,
        //0 - İnformasiya almaq üçün
        //1 - Shoot metodu üçün
        //2 - GetRemainBulletCount metodu üçün
        //3 - Reload metodu üçün
        //4 - ChangeFireMode metodu üçün
        //5 - Proqramdan dayandırmaq üçün
        //qısayoldur.
        static void Main(string[] args)


        {

            Weapon weapon = new Weapon(10,5,"tekli");

            bool f = false;

            double BulletCapacity;
            double BulletNumber;
            string FireMode;

            string operation;
            do
            {
               Console.WriteLine("1.");
               operation =Console.ReadLine("1.Shoot 2.GetRemainBulletCount 3.Reload 4.ChangeFireMode 0.Exit");

                switch(operation)
                {
                    case "1":
                        weapon.Shoot();
                        break; 
                        
                   case "2":
                       weapon.GetRemainBulletCount();
                        break;

                    case "3":
                        weapon.Fire();
                        break;

                         case "4":
                         weapon.Fire();
                        break;

                        case "0":
                        Console.WriteLine("cixis et");                       
                        break;

                      default:
                        Console.WriteLine("Yanlıs secim, zehmet olmasa yeniden cehd edin.");
                        break;
                }                 
                    
                    
           } while ( !f );









































                }
         }