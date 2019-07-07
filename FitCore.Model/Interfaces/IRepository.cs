using FitCore.Model.Training;
using FitCore.Model.User;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitCore.Model.Interfaces
{
    public interface IRepository
    {
        // Create
        // https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.addasync?view=efcore-2.1
        public Task<EntityEntry<Workout>> AddWorkoutAsync(Workout workout);

        // https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.addrangeasync?view=efcore-2.1
        public Task AddWorkoutsAsync(IEnumerable<Workout> workout);

        // Read
        // Mark as: .AsNoTracking ??
        public Task<IEnumerable<Program>> GetAllUsersWorkoutsAsync(int userId);
        public Task<Workout> GetWorkoutAsync(int workoutId);
        public Task<IEnumerable<Exercise>> GetAllExercisesAsync();
        public Task<Exercise> GetExerciseDetailsAsync(int exerciseId);

        // Update
        #region Remarks
        /*
        *  https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.update?view=efcore-2.1
        *  Update<TEntity>(TEntity) 	

           Begins tracking the given entity in the Modified state such that it will be updated in the database when SaveChanges() is called.

           All properties of the entity will be marked as modified. To mark only some properties as modified, use Attach<TEntity>(TEntity) to 
           begin tracking the entity in the Unchanged state and then use the returned EntityEntry to mark the desired properties as modified.

           A recursive search of the navigation properties will be performed to find reachable entities that are not already being tracked by 
           the context. These entities will also begin to be tracked by the context. If a reachable entity has its primary key value set then 
           it will be tracked in the Modified state. 

           If the primary key value is not set then it will be tracked in the Added state. An entity is considered to have its primary key value 
           set if the primary key property is set to anything other than the CLR default for the property type. 

           Type Parameters
           TEntity 
           The type of the entity.

           Parameters
           entity TEntity 
           The entity to update.

           Returns
           EntityEntry<TEntity>
           The EntityEntry<TEntity> for the entity. The entry provides access to change tracking information and operations for the entity.
        */
        #endregion
        public Task<EntityEntry<Workout>> UpdateWorkoutAsync(Workout workout); // update sets

        // Delete
        #region Remarks
        /*
         * https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.remove?view=efcore-2.1
           Type Parameters
           TEntity
           The type of the entity.

           Parameters
           entity TEntity 
           The entity to remove.

           Returns
           EntityEntry<TEntity>

           The EntityEntry<TEntity> for the entity. The entry provides access to change tracking information and operations for the entity.
           Remarks

           If the entity is already tracked in the Added state then the context will stop tracking the entity (rather than marking it as Deleted) since the entity was previously added to the context and does not exist in the database.

           Any other reachable entities that are not already being tracked will be tracked in the same way that they would be if Attach<TEntity>(TEntity) was called before calling this method. This allows any cascading actions to be applied when SaveChanges() is called. 
        * 
        */
        #endregion
        public Task<EntityEntry<Workout>> DeleteWorkoutAsync(Workout workout);

        // Save
        #region Remarks
        /*
        *  https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.savechangesasync?view=efcore-2.1
        * 
        *   Parameters
            cancellationToken CancellationToken 
            A CancellationToken to observe while waiting for the task to complete.
            
            Returns
            Task<Int32>
            A task that represents the asynchronous save operation. The task result contains the number of state entries written to the database.
            
            Exceptions
            DbUpdateException
            An error is encountered while saving to the database.
            
            DbUpdateConcurrencyException
            A concurrency violation is encountered while saving to the database. A concurrency violation occurs when an unexpected number of rows 
            are affected during save. This is usually because the data in the database has been modified since it was loaded into memory.
            
            Remarks
            This method will automatically call DetectChanges() to discover any changes to entity instances before saving to the underlying database. This can be disabled via AutoDetectChangesEnabled.
            Multiple active operations on the same context instance are not supported. Use 'await' to ensure that any asynchronous operations have completed before calling another method on this context. 
        */
        #endregion
        public Task<int> SaveChangesAsync();
    }
}