namespace BManger.PublicApi.Features.FreelancerFeature.Commands;

public class AddTelephoneToFreelancerCommand : IRequest<Result>
{
    public AddTelephoneToFreelancerCommand(PhoneType phoneType, string telephoneNumber, Guid freelancerId)
    {
        PhoneType = phoneType;
        TelephoneNumber = telephoneNumber;
        FreelancerId = freelancerId;
    }

    public PhoneType PhoneType { get; set; }
    public string TelephoneNumber { get; set; }
    public Guid FreelancerId { get; set; }
}

public class AddTelephoneToFreelancerHandler : IRequestHandler<AddTelephoneToFreelancerCommand, Result>
{
    private readonly IRepository<Freelancer> _repository;

    public AddTelephoneToFreelancerHandler(IRepository<Freelancer> repository)
    {
        _repository = repository;
    }
    public async Task<Result> Handle(AddTelephoneToFreelancerCommand request, CancellationToken cancellationToken)
    {
        var freelancer = await _repository.GetByIdAsync(request.FreelancerId, cancellationToken);
        if (freelancer == null)
            return Result.NotFound();
        var telephone = new Telephone() { PhoneType = request.PhoneType, TelephoneNumber = request.TelephoneNumber };
        freelancer.AddTelephone(telephone);
        await _repository.UpdateAsync(freelancer, cancellationToken);
        await _repository.SaveChangesAsync(cancellationToken);
        return Result.SuccessWithMessage("Telephone Added");
    }
}