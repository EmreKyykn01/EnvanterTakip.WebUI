using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ExcelTest.Models;

[Table("pcs")]
public partial class Pc
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(30)]
    public string Bilgisayar { get; set; } = null!;

    [StringLength(250)]
    public string Sorunu { get; set; } = null!;

    [StringLength(250)]
    public string Açıklaması { get; set; } = null!;
}
