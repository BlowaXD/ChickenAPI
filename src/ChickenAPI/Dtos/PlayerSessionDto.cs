using System;
using ChickenAPI.DAL.Interfaces.Repository;
using ChickenAPI.Player.Enums;

namespace ChickenAPI.Dtos
{
    public class PlayerSessionDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public PlayerSessionState State { get; set; }
        public Guid WorldServerId { get; set; }
    }
}