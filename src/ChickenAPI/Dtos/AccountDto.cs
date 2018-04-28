using ChickenAPI.Accounts;

namespace ChickenAPI.Dtos
{
    public class AccountDto
    {
        /// <summary>
        /// Account Id
        /// </summary>
        public ulong AccountId { get; set; }

        public AuthorityType Authority { get; set; }

        /// <summary>
        /// Account Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Hashed to Sha512
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Email used at registration
        /// </summary>
        public string RegistrationEmail { get; set; }

        /// <summary>
        /// Ip used at registration
        /// </summary>
        public string RegistrationIp { get; set; }

        /// <summary>
        /// Used for validation at registration
        /// </summary>
        public string RegistrationToken { get; set; }
    }
}