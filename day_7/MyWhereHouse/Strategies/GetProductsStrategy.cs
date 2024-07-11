﻿using MyWarehouse.Repository.Abstractions;
using MyWhereHouse.Strategies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWhereHouse.Strategies
{
    public class GetProductsStrategy : ICommandLineStrategy
    {
        IProductRepository _productRepository;
        public GetProductsStrategy(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ConsoleKey StrategyKey => ConsoleKey.A;

        public string Description => StrategyKey.ToString();

        public void Execute()
        {
            Console.WriteLine("Список продуктов:");
            var products = _productRepository.GetAll();
            foreach (var productForRead in products)
            {
                Console.WriteLine(productForRead);
            }
        }
    }
}
