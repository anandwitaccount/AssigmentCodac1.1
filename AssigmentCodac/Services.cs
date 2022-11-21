using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AssigmentCodac.IserviceClass;

namespace AssigmentCodac
{
    public class Services : IService
    {
        private readonly IRepoPosition _RepoService;
        public Services(IRepoPosition RepoService)
        {
            _RepoService = RepoService;
        }

        public void GetPositionResult()    
        {
            string direction = _RepoService.GetNameOfDirection((Directions)Enum.Parse(typeof(Directions), 
                _RepoService.Direction.ToString()));
            Console.WriteLine($"Starting Position is {_RepoService.X},{_RepoService.Y},{direction}");
            Console.WriteLine("Enter Initial Input");
            var maximumPoints = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine("Please give direction to move");
            var newMoves = Console.ReadLine().ToUpper();
            try
            {
                _RepoService.MovingStart(maximumPoints, newMoves);
                 direction = _RepoService.GetNameOfDirection((Directions)Enum.Parse(typeof(Directions),
                    _RepoService.Direction.ToString()));
                Console.WriteLine($"{_RepoService.X},{_RepoService.Y},{direction}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}
