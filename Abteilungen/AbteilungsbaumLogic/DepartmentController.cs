using AbteilungsbaumData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AbteilungsbaumLogic
{
    public class DepartmentController
    {
        DepartmentTreeEntities entities = new DepartmentTreeEntities();
        List<Department> departments = new List<Department>();

        public List<Department> getDepartments()
        {
            departments = entities.Department.AsParallel().ToList();
            return departments;
        }

        public string addDepartment(string department, string parentDepartment)
        {
            getDepartments();
            string output = null;
            int? parentId = null;
            if(string.IsNullOrEmpty(parentDepartment))
            {
                foreach (var item in departments)
                {
                    if (item.Parent_Id == null)
                    {
                        output = $"Es existiert bereits eine Abteilung der obersten Stufe (sprich ohne Parentabteilung/ {item.Name} )!";
                    }
                }
            } 
            else
            {
                foreach (var item in departments)
                {
                    if(item.Name == parentDepartment)
                    {
                        parentId = item.Id;
                    }
                }
                if (parentId == null)
                {
                    output = "Es wurde keine Abteilung gefunden, die der eingebenen Parentabteilung entspricht!";
                }
            }
            if (output == null)
            {
                if (string.IsNullOrEmpty(department))
                {
                    output = "Der Name der neuen Abteilung bitte eintragen!";
                }
                else
                {
                    entities.Department.Add(new Department() { Name = department, Parent_Id = parentId });
                    entities.SaveChanges();
                    output = $"Neue Abteilung {department} erstellt!";
                    getDepartments();
                }
            }
            return output;
        }       
    }
}
