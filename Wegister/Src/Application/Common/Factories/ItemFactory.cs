using System.Collections.Generic;
using Application.Common.Dtos;
using Application.Common.Factories.Interfaces;
using Application.Common.Viewmodels;
using Application.Items.Commands.CreateItem;
using Domain.Entities;

namespace Application.Common.Factories
{
    internal class ItemFactory : IItemFactory
    {
        public ItemListVm Create()
        {
            return new ItemListVm()
            {
                Items = new List<ItemLookupDto>()
            };
        }

        public ItemListVm Create(List<ItemLookupDto> entity)
        {
            var returnValue = Create();

            if (entity != null)
            {
                returnValue.Items = entity;
            }

            return returnValue;
        }

        public Item Create(CreateItemCommand entity)
        {
            var returnValue = new Item();

            if (entity != null)
            {
                returnValue.Name = entity.Name;
                returnValue.Price = entity.Price;
                returnValue.Unit = entity.Unit;
            }

            return returnValue;
        }

        public ItemCreated Create(Item entity)
        {
            if (entity != null)
                return new ItemCreated(entity.Id);
            else
                return null;
        }
    }
}
