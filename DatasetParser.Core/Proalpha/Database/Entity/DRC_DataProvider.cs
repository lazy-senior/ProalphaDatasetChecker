﻿using System;
using System.Collections.Generic;

namespace DatasetParser.Core.Proalpa.Database.Entity;

public partial class DRC_DataProvider
{
    public string DAO_DRC_Instance_Obj { get; set; } = null!;

    public string DRC_DataProvider_Obj { get; set; } = null!;

    public string DRC_Dataset_Obj { get; set; } = null!;

    public string Owning_Obj { get; set; } = null!;

    public string Ref_DRC_DataProvider_Obj { get; set; } = null!;

    public DRC_Instance DAO_DRC_Instance { get; set; } = null!;

    public DRC_Dataset DRC_Dataset { get; set; } = null!;

    public BG_Kopf Owning_BG_Kopf { get; set; } = null!;
}
