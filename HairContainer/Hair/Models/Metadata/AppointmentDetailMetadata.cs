using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hair.Models
{
    [ModelMetadataTypeAttribute(typeof(AppointmentDetailMetadata))]
    public partial class AppointmentDetail : IValidatableObject
    {
        public  string Capitalize(string line)
        {

            string[] nameSplit;
            if (line == null) return "";

            nameSplit = line.Split();
            line = "";
            foreach (string item in nameSplit)
            {
                if (item != "")
                    line += item.Substring(0, 1).ToUpper() + item.Substring(1).ToLower() + " ";
            }
            return line.Trim();
        }
     
        HairContext _context = new HairContext();
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            
            Appointment appointment = new Appointment();
            AppointmentDetail appointmentDetail = new AppointmentDetail();
            Product product = new Product();
            appointmentDetail = _context.AppointmentDetail
                .FirstOrDefault(a => a.AppointmentId == AppointmentId);
            appointment = _context.Appointment
                .FirstOrDefault(a => a.AppointmentId == AppointmentId);
            if (appointment.Completed == true)
            {
                yield return new ValidationResult("You cant edit completed appointement ", new[] { nameof(Appointment) });
            }
            else
            {
                //if (Comments==null)
                //{
                //    yield return new ValidationResult("no comments ", new[] { nameof(Comments) });
                //}
                product = _context.Product.FirstOrDefault(a => a.ProductId == appointmentDetail.ProductId);
                if (AppointmentId != 0)
                {
                    Comments = Capitalize(Comments);
                    if (RetailPrice == 0)
                    {
                        RetailPrice = product.RetailPrice;
                    }
                    else
                    {
                        if (RetailPrice > product.RetailPrice)
                        {
                            yield return new ValidationResult("Your price cant be over "
                                + "the retail price in product table "
                                , new[] { nameof(RetailPrice) });
                        }
                    }

                    if (ProcedureMinutes==0)
                    {
                        ProcedureMinutes = product.ProcedureMinutes;
                    }
                }
                if (ProcedureMinutes > (product.ProcedureMinutes * 2))
                {
                    yield return new ValidationResult("Your ProcedureMinutes cant be over "
                        + "the double ProcedureMinutes in product table "
                        , new[] { nameof(ProcedureMinutes) });
                }
                if (RetailPrice < 0)
                {
                    yield return new ValidationResult("Your price cant less than zero "
                        , new[] { nameof(RetailPrice) });
                }
                if (ProcedureMinutes < 0)
                {
                    yield return new ValidationResult("Your ProcedureMinutes less than zero "
                        , new[] { nameof(ProcedureMinutes) });
                }
                if (appointmentDetail.Quantity < 0)
                {
                    yield return new ValidationResult("Your quantity cant be less than zero "
                        , new[] { nameof(Quantity) });
                }
                if (Discount < 0 || Discount > 0.5)
                {
                    yield return new ValidationResult("Your quantity cant be less than zero or graeter than 50%"
                        , new[] { nameof(Discount) });
                }

                var discountamount = RetailPrice * Discount;
                Total = (RetailPrice * Quantity) - discountamount;
            }
            if (! new EmailAddressAttribute().IsValid(Comments))
	{
                yield return new ValidationResult("not Valid Email"
                       , new[] { nameof(Comments) });
            }
            yield return ValidationResult.Success;
        }
    }


    public class AppointmentDetailMetadata
    {
        public int AppointmentDetailId { get; set; }
        public int AppointmentId { get; set; }
        //[Display(Name = "Product Name")]
        public int ProductId { get; set; }
        public int ProcedureMinutes { get; set; }
        public double RetailPrice { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
        public string Comments { get; set; }

        public Appointment Appointment { get; set; }
        public Product Product { get; set; }
    }
}
