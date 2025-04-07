using HelpApp.Domain.Entities;
using FluentAssertions;
using Xunit;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace HelpApp.Domain.Test
{
    public class ProductUnitTest
    {
        #region Testes Positivos
        [Fact(DisplayName ="Create Product, with parameters Valid ")]
        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action= () => new Product(1, "Product Name", "product Description", 9.99m, 99, "/img/productImage.jpg");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }
        #endregion


        #region Testes Negativos
        [Fact(DisplayName = "Create Category With Negative Id")]
        public void CreateProduct_WithNegativeID_ResultObjetcException()
        {
            Action action = () => new Product(1, "Product Name", "product Description", 9.99m, 99, "/img/productImage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Update Invalid Id value");
        }





        [Fact(DisplayName = "Create Product With Name Empty")]
        public void CreateProduct_WithNameEmpty_ResultObjetcException()
        {
            Action action = () => new Product(1, "Product Name", "product Description", 9.99m, 99, "/img/productImage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Create Product With Name Too Short")]
        public void CreateProduct_WithTooShort_ResultObjetcException()
        {
            Action action = () => new Product(1, "Product Name", "product Description", 9.99m, 99, "/img/productImage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 characters.");
        }

        [Fact(DisplayName = "Create Name With Name Invalid")]
        public void CreateProduct_WithNameInvalid_ResultObjetcException()
        {
            Action action = () => new Product(1, "Product Name", "product Description", 9.99m, 99, "/img/productImage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Name value.");
        }




        [Fact(DisplayName = "Create Product With Description Empty")]
        public void CreateProduct_WithDescriptionEmpty_ResultObjetcException()
        {
            Action action = () => new Product(1, "Product Name", "product Description", 9.99m, 99, "/img/productImage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, name is required.");
        }

        [Fact(DisplayName = "Create Product With Description Too Short")]
        public void CreateProduct_WithDescriptionTooShort_ResultObjetcException()
        {
            Action action = () => new Product(1, "Product Name", "product Description", 9.99m, 99, "/img/productImage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, too short, minimum 5 characters.");

        }

        [Fact(DisplayName = "Create Product With Description Invalid")]
        public void CreateProduct_WithDescriptionInvalid_ResultObjetcException()
        {
            Action action = () => new Product(1, "Product Name", "product Description", 9.99m, 99, "/img/productImage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Description value.");
        }





        [Fact(DisplayName = "Create Product With Price Negative")]
        public void CreateProduct_WithPriceNegative_ResultObjetcException()
        {
            Action action = () => new Product(1, "Product Name", "product Description", 9.99m, 99, "/img/productImage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid price negative value.");
        }



        [Fact(DisplayName = "Create Product With Stock Negative")]
        public void CreateProduct_WithStockNegative_ResultObjetcException()
        {
            Action action = () => new Product(1, "Product Name", "product Description", 9.99m, 99, "/img/productImage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid stock negative value.");
        }



        [Fact(DisplayName = "Create Product With Image Too Long")]
        public void CreateProduct_WithImageTooLong_ResultObjetcException()
        {
            Action action = () => new Product(1, "Product Name", "product Description", 9.99m, 99, "/img/productImage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid image name, too long, maximum 250 characters.");
        }


        [Fact(DisplayName = "Create Product With Image Invalid")]
        public void CreateProduct_WithImagemInvalid_ResultObjetcException()
        {
            Action action = () => new Product(1, "Product Name", "product Description", 9.99m, 99, "/img/productImage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Image value.");
        }


        #endregion
    }
}
