using FluentValidation;
using ShopsRUsRetailStore.Entities.DTOs.Discount;
using ShopsRUsRetailStore.Entities.DTOs.Invoice;

namespace ShopsRUsRetailStore.API.Validations.Invoice
{
    public class AddInvoiceDtoValidator : AbstractValidator<AddInvoiceDto>
    {

        public AddInvoiceDtoValidator()
        {
            RuleFor(x => x.OrderId).NotEmpty().WithMessage("OrderId is required").GreaterThanOrEqualTo(0).WithMessage("OrderId must be greater than 0");
            RuleFor(x => x.Number).NotEmpty().WithMessage("IsPercentage is required");
            RuleFor(x => x.TotalPrice).NotEmpty().WithMessage("TotalPrice is required").GreaterThanOrEqualTo(0).WithMessage("TotalPrice must be greater than 0");
        }

    }
}
