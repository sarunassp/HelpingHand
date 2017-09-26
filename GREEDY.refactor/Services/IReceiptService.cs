using System.Collections.Generic;
using GREEDY.refactor.Models;

namespace GREEDY.refactor.Services
{
    public interface IReceiptService
    {
        List<Item> ProcessReceiptImage ();
    }
}