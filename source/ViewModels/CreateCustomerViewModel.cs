using Flunt.Notifications;
using Flunt.Validations;

namespace ViewModel
{
    public class CreateCustomerViewModel : Notifiable<Notification>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Cpf { get; set; }

        public Customer MapTo()
        {
            var contract = new Contract<Notification>()
                .Requires()
                .IsNotNull(Name, "Informe o nome!")
                .IsGreaterThan(Name, 5, "O nome deve conter mais de 5 caracteres");

            AddNotifications(contract);

            return new Customer(Guid.NewGuid(), Name, LastName, Cpf);
        }
    }
}