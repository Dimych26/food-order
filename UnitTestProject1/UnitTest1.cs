using BLL.Interfaces;
using BLL.Logic;
using BLL.ModelDTO;
using DAL.Entities;
using DAL.Interfaces;
using Moq;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class DishServiceTest
    {
        private IDishLogic dishService;
        private Mock<IRepository<Dish>> dishRepository;
        private Mock<IUnitOfWork> uow;

       

        [SetUp]
        public void Load()
        {
            uow = new Mock<IUnitOfWork>();
            dishRepository = new Mock<IRepository<Dish>>();

            uow.Setup(x => x.Dishes).Returns(dishRepository.Object);

            dishService = new DishLogic(uow.Object);
        }

       

        [Test]
        public void Create_TryToCreateElement_RepositoryShouldCallOnce()
        {
            dishService.AddDish(new DishDTO { });

            dishRepository.Verify(x => x.Create(It.IsAny<Dish>()), Times.Once);
        }

        

       

       

        

        [Test]
        public void Remove_TryToRemoveElement_RepositoryShouldCallOnce()
        {
            dishRepository.Setup(x => x.GetOne(It.IsAny<Func<Dish, bool>>())).Returns(new Dish { });

            dishService.DeleteDish(It.IsAny<int>());

            dishRepository.Verify(x => x.Remove(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void Get_TryToGetNullElement_ShouldReturnNull()
        {
            dishRepository.Setup(x => x.GetOne(It.IsAny<Func<Dish, bool>>())).Returns<Dish>(null);

            Assert.IsNull(dishService.GetDish(It.IsAny<int>()));
        }

        [Test]
        public void Get_TryToGetElement_ShouldReturnElement()
        {
            dishRepository.Setup(x => x.GetOne(It.IsAny<Func<Dish, bool>>())).Returns(new Dish { });

            Assert.IsNotNull(dishService.GetDish(It.IsAny<int>()));
        }
    }
}