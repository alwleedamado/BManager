using BManaber.Application.Entites;
using BManager.Application.Enums;
using BManager.Application.Exceptions;
using BManager.Utils.Abstractions;
using BManager.Utils.Enums;

namespace BManager.Application.Entites.FreelancerAggregate
{
    public class Freelancer : AuditEntity<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        private readonly List<Telephone> _telephones = new List<Telephone>();
        public IReadOnlyCollection<Telephone> Telephones => _telephones.AsReadOnly();
        private readonly List<Speciality> _specialities = new List<Speciality>();
        public IReadOnlyCollection<Speciality> Specialities => _specialities.AsReadOnly();

        public Freelancer(string name, string email, Gender gender)
        {
            Name = name;
            Email = email;
            Gender = gender;
        }
        public void AddSpeciality(Guid specialityTypeId)
        {
            if (_specialities.Any(x => x.SpecialityTypeId == specialityTypeId))
                throw new DuplicateException("This freelancer already has this speciality");
            _specialities.Add(new Speciality { SpecialityTypeId = specialityTypeId });
        }

        public void RemoveSpeciality(Guid specialityId)
        {
            var sp = _specialities.FirstOrDefault(x => x.Id == specialityId);
            if (sp != null)
                _specialities.Remove(sp);
        }
        public void AddTelephone(Telephone telephone)
        {
            if (Telephones.Any(x => x.TelephoneNumber == telephone.TelephoneNumber && x.PhoneType == telephone.PhoneType))
                throw new DuplicateException("This freelancer already has this telephone");
            _telephones.Add(telephone);
        }

        public void RemoveTelephone(Guid telephoneId)
        {
            var telephone = _telephones.FirstOrDefault(x => x.Id == telephoneId);
            if (telephone != null)
                _telephones.Remove(telephone);
        }
    }
}
