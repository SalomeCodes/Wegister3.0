using System.Collections.Generic;
using Application.Common.Dtos;

namespace Application.Common.Viewmodels
{
    public class ItemListVm
    {
        public IList<ItemLookupDto> Items { get; set; }
    }
}
