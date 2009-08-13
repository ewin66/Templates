using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Sample.Data.Generated.ManagerObjects;
using Sample.Data.Generated.BusinessObjects;
using Sample.Data.Generated.Base;

namespace Sample.Data.Generated.UnitTests
{
	[TestFixture]
    public partial class CartTests : UNuitTestBase
    {
        protected ICartManager manager;
		
		public CartTests()
        {
            manager = managerFactory.GetCartManager();
        }
		
		protected Cart CreateNewCart()
		{
			Cart entity = new Cart();
			
			
			entity.ItemId = "Test ";
			entity.Name = "Test Test Test Test Test Test Test Test Test Test Test Test Test T";
			entity.Type = "Test T";
			entity.Price = 25;
			entity.CategoryId = "Test Te";
			entity.ProductId = "Tes";
			entity.IsShoppingCart = true;
			entity.Quantity = 88;
			
			IProfileManager profileManager = managerFactory.GetProfileManager();
			entity.Profile = profileManager.GetAll(1)[0];
			
			return entity;
		}
		protected Cart GetFirstCart()
        {
            IList<Cart> entityList = manager.GetAll(1);
            if (entityList.Count == 0)
                Assert.Fail("All tables must have at least one row for unit tests to succeed.");
            return entityList[0];
        }
		
		[Test]
        public void Create()
        {
            try
            {
				Cart entity = CreateNewCart();
				
                object result = manager.Save(entity);

                Assert.IsNotNull(result);
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
        [Test]
        public void Read()
        {
            try
            {
                Cart entityA = CreateNewCart();
				manager.Save(entityA);

                Cart entityB = manager.GetById(entityA.Id);

                Assert.AreEqual(entityA, entityB);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
		[Test]
		public void Update()
        {
            try
            {
                Cart entityA = GetFirstCart();
				
				entityA.ItemId = "Test Tes";
				
				manager.Update(entityA);

                Cart entityB = manager.GetById(entityA.Id);

                Assert.AreEqual(entityA.ItemId, entityB.ItemId);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
        [Test]
        public void Delete()
        {
            try
            {
                Cart entity = GetFirstCart();
				
                manager.Delete(entity);

                entity = manager.GetById(entity.Id);
                Assert.IsNull(entity);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
	}
}
