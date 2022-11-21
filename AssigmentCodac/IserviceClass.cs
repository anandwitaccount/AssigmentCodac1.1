using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentCodac
{
    public class IserviceClass

    {
        public interface IRepoPosition
        {
            void MovingStart(List<int> maxPoints, string moves);
            string GetNameOfDirection(Directions Direction);
            public int X { get; set; }
            public int Y { get; set; }
            public Directions Direction { get; set; }
        }
        public interface IService
        {
            void GetPositionResult();

        }
    }
}
