﻿using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DataAccessLayer.Abstract
{
    public interface ICrewDal:IGenericDal<Crew>
    {
        int GetCrewCount();
        List<Crew> Last4Crew();
    }
}