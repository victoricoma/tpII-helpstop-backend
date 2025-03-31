using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpApp.Domain.Entities;
using FluentAssertions;
using Xunit;

namespace HelpApp.Domain.Test
{
    public class ProductUnitTest
    {
        #region Testes Positivos
        [Fact(DisplayName = "Create Product, with parameter Valid")] 
        public void CreateProduct_WithValidParameters_ResultObjectsValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product, with Id Valid")]
        public void CreateProduct_WithIdValid_ResultObjectsValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }
        #endregion

        #region Testes Negativos
        [Fact(DisplayName = "Create Product, with negative Id")]
        public void CreateProduct_WithNegativeId_ResultObjectsValidState()
        {
            Action action = () => new Product(-1, "Product Name", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Update Invalid Id value");

        }

        [Fact(DisplayName = "Create Product, with Name Empty")]
        public void CreateProduct_WithNameEmpty_ResultObjectsValidState()
        {
            Action action = () => new Product(1, "", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Create Product, with Alone Name")]
        public void CreateProduct_WithAloneName_ResultObjectsValidState()
        {
            Action action = () => new Product(1, "", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Create Product, with Name Too Short")]
        public void CreateProduct_WithNameTooShort_ResultObjectsValidState()
        {
            Action action = () => new Product(1, "Pr", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 characters.");
        }

        [Fact(DisplayName = "Create Product, with Alone Description")]
        public void CreateProduct_WithAloneDescreption_ResultObjectsValidState()
        {
            Action action = () => new Product(1, "Product Name", "", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, description is required.");
        }

        [Fact(DisplayName = "Create Product, with Description Empty")]
        public void CreateProduct_WithDescreptionEmpty_ResultObjectsValidState()
        {
            Action action = () => new Product(1, "Product Name", "", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, description is required.");
        }

        [Fact(DisplayName = "Create Product, with Description Too Short")]
        public void CreateProduct_WithDescreptionTooShort_ResultObjectsValidState()
        {
            Action action = () => new Product(1, "Product Name", "Prod", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, too short, minimum 5 characters.");
        }

        [Fact(DisplayName = "Create Product, with price negative")]
        public void CreateProduct_WithPriceNegative_ResultObjectsValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Descreption", -1, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid price negative value.");
        }

        [Fact(DisplayName = "Create Product, with stock negative")]
        public void CreateProduct_WithStockNegative_ResultObjectsValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Descreption", 9.99m, -1, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid stock negative value.");
        }

        [Fact(DisplayName = "Create Product, with Image Name")]
        public void CreateProduct_WithImageNameInvalid_ResultObjectsValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Descreption", 9.99m, 99, "/img/productimagejekdfwugeeiaysbhuwakeukwayejbuwoiefbnuioyhw4fboweufoiwquebfowiuyfbwo8ifuybQOILWUJBNDo9uipyqwbgpoqiyufhjbweo9fywbefikjhiwbnfouiwyfbwibjuwo8rgyfcjklneaskrvgdkfgdngiedkungoliedsufngsledinjubolrisduuierçkilgnjuergiungeguniqpirguuinre.jpg\"");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid image name, too long, maximum 250 characters.");
        }

        #endregion
    }
}
