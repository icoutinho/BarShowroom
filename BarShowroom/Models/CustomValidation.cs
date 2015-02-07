using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BarShowroom.Models
{
    public class BreweryExists : ValidationAttribute
    {
        public BreweryExists(bool bExists)
            : base("{0} check if brewery already exists")
        {
            m_bExists = bExists;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                BarShowroomDb _db = new BarShowroomDb();
                try
                {
                    if (value is Brewery)
                    {
                        Brewery brvalue = (Brewery)value;
                        Brewery br = _db.Breweries.Single(s => s.Name == brvalue.Name);
                    }
                    else
                    {
                        Brewery brewery = _db.Breweries.Single(s => s.Name == value);
                    }
                }
                catch (Exception ex)
                {
                    if (_db != null) _db.Dispose();
                    if (!m_bExists)
                        return ValidationResult.Success;
                    return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
                }
                if (_db != null) _db.Dispose();
                if (m_bExists)
                    return ValidationResult.Success;
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));

            }
            return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
        }

        private readonly bool m_bExists;
    }



    public class BarExists : ValidationAttribute
    {
        public BarExists(bool bExists)
            : base("{0} check if bar already exists")
        {
            m_bExists = bExists;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                BarShowroomDb _db = new BarShowroomDb();
                try
                {
                    Bar bar = _db.Bars.Single(s => s.Name == value);
                }
                catch (Exception ex)
                {
                    if (_db != null) _db.Dispose();
                    if (!m_bExists)
                        return ValidationResult.Success;
                    return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
                }
                if (_db != null) _db.Dispose();
                if (m_bExists)
                    return ValidationResult.Success;
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));

            }
            return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
        }

        private readonly bool m_bExists;
    }

    public class BeerExists : ValidationAttribute
    {
        public BeerExists(bool bExists)
            : base("{0} check if beer already exists")
        {
            m_bExists = bExists;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                BarShowroomDb _db = new BarShowroomDb();
                try
                {
                    Beer beer = _db.Beers.Single(s => s.Name == value);
                }
                catch (Exception ex)
                {
                    if (_db != null) _db.Dispose();
                    if (!m_bExists)
                        return ValidationResult.Success;
                    return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
                }
                if (_db != null) _db.Dispose();
                if (m_bExists)
                    return ValidationResult.Success;
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));

            }
            return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
        }

        private readonly bool m_bExists;
    }

}