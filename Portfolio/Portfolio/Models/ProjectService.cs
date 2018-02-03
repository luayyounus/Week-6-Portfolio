﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Data;

namespace Portfolio.Models
{
    public class ProjectService : IProjectService
    {
        private readonly ProjectDbContext _context;
        public ProjectService(ProjectDbContext context)
        {
            _context = context;
        }
        public async Task DeleteAsync(int id)
        {
            _context.Projects.Remove(new Project {Id = id});
            await _context.SaveChangesAsync();
        }

        public Project FindProject(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Project> FindAsync()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Project> GetAll(int? count = null, int? page = null)
        {
            throw new NotImplementedException();
        }

        public Task<Project[]> GetAllAsync(int? count = null, int? page = null)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Project project)
        {
            throw new NotImplementedException();
        }
    }
}