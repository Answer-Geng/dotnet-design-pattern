using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Leave
{
    class Program
    {
        static void Main(string[] args)
        {
            Leader leader = new Leader();
            Manager manager = new Manager();
            Director director = new Director();
            leader.SetSuccessor(manager);
            manager.SetSuccessor(director);

            LeaveRequest jack = new LeaveRequest
            {
                Applicant = "Jack",
                Days = 2
            };

            LeaveRequest tom = new LeaveRequest
            {
                Applicant = "Tom",
                Days = 30
            };

            LeaveRequest mike = new LeaveRequest
            {
                Applicant = "Mike",
                Days = 4
            };

            leader.Approve(jack);
            leader.Approve(tom);
            leader.Approve(mike);
            Console.ReadLine();
        }
    }
}
