using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using ShopsRUsRetailStore.API.Controllers.V1;
using ShopsRUsRetailStore.Core.DTOs.Result;
using ShopsRUsRetailStore.Entities.Concrete;
using ShopsRUsRetailStore.Entities.DTOs.Invoice;
using ShopsRUsRetailStore.Entities.Enums;
using ShopsRUsRetailStore.Services.Abstract;

namespace ShopsRUsRetailStore.Test
{
    public class InvoiceTest
    {

        private readonly Mock<IInvoiceService>? _invoiceService = new();


        [Fact]
        public async void Add_Invoice_Return_200()
        {
            Order ord = new Order()
            {
                TotalPrice = 1000,
                Id = 1,
                CreatedDate = DateTime.Now,
                Number = "RAM-2022",
                ModifiedDate = DateTime.Now,
            };
            var addInvoiceDto = new Entities.DTOs.Invoice.AddInvoiceDto()
            {
                Number = $"INV202022000026801",
                TotalPrice = ord.TotalPrice,
                OrderId = ord.Id,
            };

            var serviceAddResponse = new ResponseDto<InvoiceDto>() { StatusCode = 200 };
            _invoiceService.Setup(x => x.AddAsync(addInvoiceDto)).ReturnsAsync(serviceAddResponse);


            InvoiceController invController = new InvoiceController(_invoiceService.Object);
            var incControllerAddResponse = (await invController.Add(addInvoiceDto)) as ObjectResult;

            Assert.NotNull(incControllerAddResponse.StatusCode);
            Assert.True(serviceAddResponse.StatusCode == incControllerAddResponse.StatusCode.Value);
        }


        [Theory]
        [InlineData(UserTypeEnum.Employee, 1000,700)]
        [InlineData(UserTypeEnum.Affiliate, 1000,900)]
        public async void Add_Invoice_With_UserType_And_TotalPrice_Return_TotalPriceAfterDiscount(UserTypeEnum userType, decimal totalPrice,decimal totalPriceAfterDiscount)
        {

            User user = new()
            {
                Id = "f575f-a333-4d94-81f1-ad27652a1461",
                Type = userType,
                UserName = $"ramazan",
                NormalizedUserName = $"ramazan".ToUpper(),
                FirstName = $"Ramazan",
                LastName = $"Gunes",
                Email = $"ramazann@gmail.com",
                NormalizedEmail = $"ramazann@gmail.com".ToUpper(),
                ConcurrencyStamp = "79114edf-6c8d-494d-8e91-05caaadb920a",
                SecurityStamp = "72545538-a690-40df-bdb5-10a8a24e06e4",
                CreatedDate = new DateTime(2022, 1, 1)
            };
             

            Order ord = new Order()
            {
                TotalPrice = totalPrice,
                Id = 1,
                CreatedDate = DateTime.Now,
                Number = "RAM-2022",
                ModifiedDate = DateTime.Now,
                UserId = user.Id,
                User = user,
            };

            var addInvoiceDto = new Entities.DTOs.Invoice.AddInvoiceDto()
            {
                Number = $"INV202022000026801",
                TotalPrice = totalPrice,
                OrderId = ord.Id,
            };


            var invoiceDto = new InvoiceDto() { Order = ord, Number = "RAM2022", TotalPrice = totalPriceAfterDiscount };
            var response1 = new ResponseDto<InvoiceDto>() { Data = invoiceDto, StatusCode = 200 };
            _invoiceService.Setup(x => x.AddAsync(addInvoiceDto)).ReturnsAsync(response1);


            InvoiceController invController = new InvoiceController(_invoiceService.Object);
            var ss = (await invController.Add(addInvoiceDto)) as ObjectResult;
            var data = ((ss.Value as ResponseDto<InvoiceDto>)!).Data;
            
            
            Assert.NotNull(data);
            Assert.True(response1.Data.TotalPrice == data.TotalPrice);
        }

        [Theory]
        [InlineData(UserTypeEnum.Customer, 1000, 950)]
        public async void Add_Invoice_With_UserType_And_TotalPrice_TwoYearsUser_Return_TotalPriceAfterDiscount(UserTypeEnum userType, decimal totalPrice, decimal totalPriceAfterDiscount)
        {

            User user = new()
            {
                Id = "f575f-a333-4d94-81f1-ad27652a1461",
                Type = userType,
                UserName = $"ramazan",
                NormalizedUserName = $"ramazan".ToUpper(),
                FirstName = $"Ramazan",
                LastName = $"Gunes",
                Email = $"ramazann@gmail.com",
                NormalizedEmail = $"ramazann@gmail.com".ToUpper(),
                ConcurrencyStamp = "79114edf-6c8d-494d-8e91-05caaadb920a",
                SecurityStamp = "72545538-a690-40df-bdb5-10a8a24e06e4",
                CreatedDate = new DateTime(2019, 1, 1)
            };


            Order ord = new Order()
            {
                TotalPrice = totalPrice,
                Id = 1,
                CreatedDate = DateTime.Now,
                Number = "RAM-2022",
                ModifiedDate = DateTime.Now,
                UserId = user.Id,
                User = user,
            };

            var addInvoiceDto = new Entities.DTOs.Invoice.AddInvoiceDto()
            {
                Number = $"INV202022000026801",
                TotalPrice = totalPrice,
                OrderId = ord.Id,
            };


            var invoiceDto = new InvoiceDto() { Order = ord, Number = "RAM2022", TotalPrice = totalPriceAfterDiscount };
            var response1 = new ResponseDto<InvoiceDto>() { Data = invoiceDto, StatusCode = 200 };
            _invoiceService.Setup(x => x.AddAsync(addInvoiceDto)).ReturnsAsync(response1);


            InvoiceController invController = new InvoiceController(_invoiceService.Object);
            var ss = (await invController.Add(addInvoiceDto)) as ObjectResult;
            var data = ((ss.Value as ResponseDto<InvoiceDto>)!).Data;


            Assert.NotNull(data);
            Assert.True(response1.Data.TotalPrice == data.TotalPrice);
        }

    }
}