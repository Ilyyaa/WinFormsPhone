using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneDB.Modals;

public partial class Phonebook
{
    [Key]
    public int Id { get; set; }

    [MaxLength(30)]
    public string Lastname { get; set; } = null!;

    [MaxLength(30)]
    public string Name { get; set; } = null!;

    [MaxLength(30)]
    public string? Patronymic { get; set; }

    [MaxLength(60)]
    public string Street { get; set; } = null!;

    [Column(TypeName = "decimal(4, 0)")]
    public decimal House { get; set; }

    [Column(TypeName = "decimal(4, 0)")]
    public decimal Flat { get; set; }

    [MaxLength(10)]
    public string? Phone { get; set; }
}
