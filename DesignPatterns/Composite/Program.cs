using System.Collections;

namespace Composite
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee kemal = new Employee { Name = "Kemal Yanmaz" };
            Employee ulas= new Employee { Name = "Ulaş Yanmaz" };
            Employee engin = new Employee { Name = "Engin Demiroğ" };
            kemal.AddSubordinate(ulas);
            kemal.AddSubordinate(engin);
            foreach (Employee manager in kemal)
            {
                Console.WriteLine(manager.Name);
                foreach (var employee in manager)
                {
                    Console.Write(employee.Name);
                }
            }
        }
    }

    public interface IPerson
    {
        string Name { get; set; }
    }

    public class Employee : IPerson, IEnumerable<IPerson>
    {
        List<IPerson> _subordinates = new List<IPerson>();

        public void AddSubordinate(IPerson person)
        {
            _subordinates.Add(person);
        }

        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }

        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public string Name { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}