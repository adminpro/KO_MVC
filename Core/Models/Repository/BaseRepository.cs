using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Core.Models.Repository
{
    /// <summary>
    /// Class BaseRepository
    /// </summary>
    /// <typeparam name="TKey">The type of the T key.</typeparam>
    /// <typeparam name="TEntity">The type of the T entity.</typeparam>
    public class BaseRepository<TKey, TEntity> : IBaseRepository<TKey, TEntity> where TEntity : class
    {
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public string UserName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository{TKey, TEntity}"/> class.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        public BaseRepository(string userName)
        {
            this.UserName = userName;
            if (_context == null)
            {
                _context = new CmsContext();
                Entities = _context.Set<TEntity>();
            }
        }
        /// <summary>
        /// The _context
        /// </summary>
        private CmsContext _context;
        /// <summary>
        /// The entities
        /// </summary>
        private DbSet<TEntity> Entities;
        /// <summary>
        /// Gets the specified filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>IEnumerable{`1}.</returns>
        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, string includeProperties)
        {
            IQueryable<TEntity> query = Entities;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }

        }
        /// <summary>
        /// Gets the paging.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <param name="pIndex">Index of the p.</param>
        /// <param name="pSize">Size of the p.</param>
        /// <returns>IEnumerable{`1}.</returns>
        public IEnumerable<TEntity> GetPaging(Expression<Func<TEntity, bool>> filter, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, string includeProperties, int pIndex, int pSize)
        {
            IQueryable<TEntity> query = Entities;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).Skip(pIndex * pSize).Take(pSize).ToList();
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>List{`1}.</returns>
        public IQueryable<TEntity> GetAll()
        {
            return Entities.AsQueryable();
        }
        /// <summary>
        /// Gets the by id.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>`1.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public TEntity GetById(TKey key)
        {
            return Entities.Find(key);
        }
        /// <summary>
        /// Creates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>`1.</returns>
        public TEntity Create(TEntity entity)
        {
            Entities.Add(entity);
            return entity;
        }
        /// <summary>
        /// Creates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="saveChanges">if set to <c>true</c> [save changes].</param>
        /// <returns>`1.</returns>
        public TEntity Create(TEntity entity, bool saveChanges)
        {
            Entities.Add(entity);
            if (saveChanges)
                this.SaveChanges();
            return entity;
        }
        /// <summary>
        /// Edits the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="entity">The entity.</param>
        /// <returns>`1.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public TEntity Edit(TKey key, TEntity entity)
        {
            Entities.Attach(entity);
            _context.Entry<TEntity>(entity).State = EntityState.Modified;
            return entity;
        }
        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        public bool Delete(TEntity entity)
        {
            if (entity == null)
                return false;
            Entities.Remove(entity);
            return true;
        }
        /// <summary>
        /// Saves the change.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool SaveChanges()
        {
            //Log and save to database
            if (!string.IsNullOrEmpty(this.UserName))
                return _context.SaveChanges() > 0;
            return false;
        }
    }
}
