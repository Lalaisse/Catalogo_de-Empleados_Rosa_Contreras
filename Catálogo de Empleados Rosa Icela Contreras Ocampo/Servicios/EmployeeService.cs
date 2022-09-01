using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catálogo_de_Empleados_Rosa_Icela_Contreras_Ocampo.Servicios
{
    public class EmployeeService
    {
        /// <summary>
        /// Método para poder buscar todos los empleados registrados
        /// </summary>
        /// <returns></returns>
        public static List<EmployeesRosa> getAll()//estatic es para evitar estanciar el objeto como new, y hacerlo directo
        {
            
            try
            {
                List<EmployeesRosa> listEmployees = new List<EmployeesRosa>();
                using (var db= new DB_ITSEntities()) //Se conecta con la bd
                {
                    listEmployees = db.EmployeesRosa.ToList();
                }
                return listEmployees;
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un error al intentar traer la lista de empleados");
                throw;
            }   
        }

        /// <summary>
        /// Método para guardar un nuevo empleado
        /// </summary>
        /// <param name="contacto"></param>
        public static void Agregar(EmployeesRosa employee)
        {
            try
            {
                using (var db = new DB_ITSEntities())
                {
                    db.EmployeesRosa.Add(employee);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un error al intentar agregar un empleado");
            }
        }

        /// <summary>
        /// Método para buscar un empleado en la bd según el id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static EmployeesRosa Buscar(int id)
        {
            var employee = new EmployeesRosa();
            try
            {
                using (var db = new DB_ITSEntities())
                {
                    employee = db.EmployeesRosa.Find(id);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un error al intentar encontrar un empleado");
            }
            return employee;
        }


        /// <summary>
        /// Método para actualizar en la base de datos
        /// </summary>
        /// <param name="contacto"></param>
        public static void Modificar(EmployeesRosa employee)
        {
            try
            {
                using (var db = new DB_ITSEntities())
                {
                    db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un error al intenntar modificar un empleado");
            }
        }


        /// <summary>
        /// Método para actualizar en la base de datos una baja lógica
        /// </summary>
        /// <param name="contacto"></param>
        public static void BajaLogica(EmployeesRosa employee)
        {
            try
            {
                using (var db = new DB_ITSEntities())
                {
                    db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un error al intenntar modificar un empleado");
            }
        }



    }
}