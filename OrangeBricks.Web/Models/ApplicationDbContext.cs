using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.Validation;
using System.Linq;

namespace OrangeBricks.Web.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IOrangeBricksContext
    {
        public ApplicationDbContext()
            : base("aspnet-OrangeBricks.Web-20170407152500", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<Property> Properties { get; set; }
        public IDbSet<Offer> Offers { get; set; }
        public IDbSet<File> Files { get; set; }         // - handle property image
        public IDbSet<Viewing> Viewings { get; set; }   // -

        public new void SaveChanges()
        {
            try // - debug only
            {
                base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join(" ; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, "The validation errors are:", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }
    }

    public interface IOrangeBricksContext
    {
        IDbSet<Property> Properties { get; set; }

        IDbSet<Offer> Offers { get; set; }
   
        IDbSet<File> Files { get; set; } //-

        IDbSet<Viewing> Viewings { get; set; }   // -

        void SaveChanges();
    }
}