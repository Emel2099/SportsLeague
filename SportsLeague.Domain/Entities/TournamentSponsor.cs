
namespace SportsLeague.Domain.Entities
{
    internal class TournamentSponsor : AuditBase
    {
        public int TournamentId { get; set; }

        public int SponsorId { get; set; }

        public decimal ContractAmount { get; set; } //Monto del contrato

        public DateTime JoinedAt { get; set; } // Fecha de vinculación

        // Navigation Properties

        public Sponsor Sponsor { get; set; } = null!;

        public Tournament Tournament { get; set; } = null!;

    }
}
