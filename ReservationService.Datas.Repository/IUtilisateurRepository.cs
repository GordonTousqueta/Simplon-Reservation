﻿using ReservationService.Datas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationService.Datas.Repository
{
    public interface IUtilisateurRepository
    {
        Task<IEnumerable<Utilisateur>> GetAllUserAsync();
        Task<Utilisateur> GetUserById();
        Task<bool> SaveUserAsync();
    }
}
