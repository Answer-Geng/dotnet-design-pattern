using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Leave
{
    class Manager : Approver
    {
        public override void Approve(LeaveRequest request)
        {
            if (request.Days <= 5)
            {
                Console.WriteLine($"{this.GetType().Name} approved request {request.Applicant},{request.Days}");
            }
            else if (_successor != null)
            {
                _successor.Approve(request);
            }
        }
    }
}
