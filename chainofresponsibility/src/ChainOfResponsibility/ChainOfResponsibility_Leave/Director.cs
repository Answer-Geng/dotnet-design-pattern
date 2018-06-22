using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Leave
{
    class Director : Approver
    {
        public override void Approve(LeaveRequest request)
        {
            Console.WriteLine($"{this.GetType().Name} approved request {request.Applicant},{request.Days}");
        }
    }
}
