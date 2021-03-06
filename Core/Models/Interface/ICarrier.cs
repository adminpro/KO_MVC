﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Models.Interface
{
    public interface ICarrier<Key>
    {
        Carrier GetCarrier(Key key);
        bool ExistsCarrier(Carrier carrier);
    }
}
