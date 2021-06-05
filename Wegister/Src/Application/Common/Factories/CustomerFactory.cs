﻿using System.Collections.Generic;
using Application.Common.Dtos;
using Application.Common.Factories.Interfaces;
using Application.Common.Viewmodels;
using Application.Customers.Commands.CreateCustomer;
using Application.Items.Commands.CreateItem;
using Domain.Entities;

namespace Application.Common.Factories
{
    internal class CustomerFactory : ICustomerFactory
    {
        public CustomerListVm Create(List<CustomerLookupDto> entity)
        {
            var returnValue = new CustomerListVm();

            if (entity != null)
            {
                returnValue.Customers = entity;
            }

            return returnValue;
        }

        public Customer Create(CreateCustomerCommand entity)
        {
            var returnValue = new Customer();

            if (entity != null)
            {
                returnValue.Name = entity.Name;
                returnValue.Email = entity.Email;
                returnValue.EmailToSendHoursTo = entity.EmailToSendHoursTo;
                returnValue.Street = entity.Street;
                returnValue.HouseNumber = entity.HouseNumber;
                returnValue.Place = entity.Place;
                returnValue.ZipCode = entity.ZipCode;
            }

            return returnValue;
        }

        public CustomerCreated Create(Customer entity)
        {
            if (entity != null)
                return new CustomerCreated(entity.Id);
            else
                return null;
        }
    }
}
