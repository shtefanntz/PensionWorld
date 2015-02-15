namespace PensionWorld.Services.Reservations.TransactionService
{
    using System.Linq;
    using System.Transactions;

    using PensionWorld.Domain.MasterData;
    using PensionWorld.Domain.Repositories;
    using PensionWorld.Domain.TransactionScripts;
    using PensionWorld.Services.DTO;
    using PensionWorld.Services.Infrastructure;

    using ReservationStatus = PensionWorld.Domain.TransactionScripts.ReservationStatus;

    // TransactionScript 
    public class ReservationService
    {
        private readonly ICustomerRepository customerRepository;

        private readonly IMailSender mailSender;

        private readonly IReservationRepository repository;

        public ReservationService(
            IReservationRepository repository,
            ICustomerRepository customerRepository,
            IMailSender mailSender)
        {
            this.repository = repository;
            this.customerRepository = customerRepository;
            this.mailSender = mailSender;
        }

        public ReservationResult CreateReservation(ReservationDto dto)
        {
            using (var transactionScope = new TransactionScope())
            {
                var reservation = this.MapFromDTO(dto);

                var validateReservation = this.ValidateReservation(reservation);
                if (!validateReservation.IsValid)
                {
                    return new ReservationResult { ErrorMessage = validateReservation.Reason };
                }

                this.repository.Add(reservation);

                this.SendConfirmation(reservation);

                transactionScope.Complete();

                return new ReservationResult();
            }
        }
        
        public ReservationResult UpdateReservation(ReservationDto dto)
        {
            using (var transactionScope = new TransactionScope())
            {
                var reservation = this.MapFromDTO(dto);
                reservation.Id = dto.Id;

                var validateReservation = this.ValidateReservation(reservation);
                if (!validateReservation.IsValid)
                {
                    return new ReservationResult { ErrorMessage = validateReservation.Reason };
                }

                this.repository.Update(reservation);

                this.SendConfirmation(reservation);

                transactionScope.Complete();

                return new ReservationResult();
            }
        }

        private void SendConfirmation(Reservation reservation)
        {
            var customer = this.customerRepository.GetById(reservation.CustomerId);
            this.mailSender.Send(
                customer.Contact,
                this.GetMessageBody(reservation),
                this.GetMessageSubject(reservation, customer));
        }

        private string GetMessageSubject(Reservation reservation, Customer customer)
        {
            return string.Format(
                "Dear Mr./Mrs. {0}, Your reservation status is {1}",
                customer.LastName,
                reservation.Status);
        }

        private string GetMessageBody(Reservation reservation)
        {
            return string.Format("Reservation with reference number {0}", reservation.ReferenceNumber);
        }

        private ValidationResult ValidateReservation(Reservation reservation)
        {
            var endDate = reservation.BeginDate.AddDays(reservation.Days);
            var allReservationBetween = this.repository.GetAllReservationBetween(
                reservation.RoomId,
                reservation.BeginDate,
                endDate);

            if (allReservationBetween.Any(r => r.Id != reservation.Id))
            {
                return ValidationResult.Invalid("The selected period is not available");
            }

            // other validations

            return ValidationResult.Valid;
        }

        private Reservation MapFromDTO(ReservationDto dto)
        {
            return new Reservation
                       {
                           CustomerId = dto.CustomerId,
                           BeginDate = dto.BeginDate,
                           Days = dto.Days,
                           PensionId = dto.PensionId,
                           RoomId = dto.RoomId,
                           Amount = dto.Amount,
                           ReferenceNumber = dto.ReferenceNumber,
                           Status = (ReservationStatus)dto.Status
                       };
        }
    }
}