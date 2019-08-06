using BLL.Interfaces;
using BLL.Logic;
using BLL.ModelDTO;
using DAL.Entities;
using DAL.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestFixture]
    public class MenuServiceTest
    {
        private IMenuLogic dishService;
        private Mock<IRepository<Menu>> dishRepository;
        private Mock<IUnitOfWork> uow;



        [SetUp]
        public void Load()
        {
            uow = new Mock<IUnitOfWork>();
            dishRepository = new Mock<IRepository<Menu>>();

            uow.Setup(x => x.Menu).Returns(dishRepository.Object);

            dishService = new MenuLogic(uow.Object);
        }



        [Test]
        public void Create_TryToCreateElement_RepositoryShouldCallOnce()
        {
            dishService.Create(new MenuDTO { });

            dishRepository.Verify(x => x.Create(It.IsAny<Menu>()), Times.Once);
        }









        [Test]
        public void Remove_TryToRemoveElement_RepositoryShouldCallOnce()
        {
            dishRepository.Setup(x => x.GetOne(It.IsAny<Func<Menu, bool>>())).Returns(new Menu { });

            dishService.Remove(It.IsAny<int>());

            dishRepository.Verify(x => x.Remove(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void Get_TryToGetNullElement_ShouldReturnNull()
        {
            dishRepository.Setup(x => x.GetOne(It.IsAny<Func<Menu, bool>>())).Returns<Menu>(null);

            Assert.IsNull(dishService.Get(It.IsAny<int>()));
        }

        [Test]
        public void Get_TryToGetElement_ShouldReturnElement()
        {
            dishRepository.Setup(x => x.GetOne(It.IsAny<Func<Menu, bool>>())).Returns(new Menu { });

            Assert.IsNotNull(dishService.Get(It.IsAny<int>()));
        }
    }
}
