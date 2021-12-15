﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Tests
{
    [TestClass]
    class CartTests
    {
        private CartItem _cartItem; 
        private CartManager _cartManager;
        [TestInitialize]
        public void TestInitialize()
        {
            _cartManager = new CartManager();
            _cartItem = new CartItem
            {
                Product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 2500
                },
                Quantity = 1
            };

            _cartManager.Add(_cartItem);

        }
        [TestCleanup]
        public void TestCleanup()

        {
            _cartManager.Clear();
        }
        [TestMethod]
        public void Sepete_Urun_Eklenebilmelidir()
        {
            //Arrange
            const int beklenen = 1;
            
            //Act
            _cartManager.Add(_cartItem);
            var toplamElemanSayisi = _cartManager.TotalItems;

            //Assert
            Assert.AreEqual(beklenen, toplamElemanSayisi);

        }
        [TestMethod]
        public void Sepette_Olan_Urun_Cikarilabilmelidir()
        {
            //Arrange
            var SepetteOlanElemanSayisi = _cartManager.TotalItems;

            //Act
            _cartManager.Remove(1);
            var SepetteKalanElemanSayisi = _cartManager.TotalItems;

            //Assert
            Assert.AreEqual(SepetteOlanElemanSayisi-1,SepetteKalanElemanSayisi);
        }

        [TestMethod]
        public void Sepet_Temizlenebilmelidir()
        {
            //Act
            _cartManager.Clear();

            //Assert
            Assert.AreEqual(0, _cartManager.TotalQuantity);
            Assert.AreEqual(0, _cartManager.TotalItems);
        }
    }
}
