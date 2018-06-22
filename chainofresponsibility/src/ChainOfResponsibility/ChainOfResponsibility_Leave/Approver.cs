using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Leave
{
    abstract class Approver
    {
        protected Approver _successor;
        public void SetSuccessor(Approver successor)
        {
            _successor = successor;
        }

        public abstract void Approve(LeaveRequest request);
    }
}
