﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travela.EntityLayer.Concrete;

namespace Travela.DataAccesLayer.Abstract
{
    public interface IDestinationDal : IGenericDal<Destination>
    {
        List<Destination> GetDestinationByCategoryList(int id);
        List<Destination> GetDestinationByCategoryListAll();
    }
}
