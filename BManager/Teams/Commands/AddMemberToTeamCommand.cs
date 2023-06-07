using BManager.PublicApi.Dtos;
using System.ComponentModel.DataAnnotations;

namespace BManager.Teams.Commands
{
    public class AddMemberToTeamCommand
    {
        public Guid FreelancerId { get; set; }
        public Guid SpecialityTypeId { get; set; }
        public decimal Salary { get; set; }
    }
}
