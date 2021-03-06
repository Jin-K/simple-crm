using SimpleCMS.Business.Models;
using SimpleCMS.Data.Entities;
using System.Collections.Generic;

namespace SimpleCMS.Business.Providers {

	public interface IElementsStore {

         List<Entidad> GetAllEntities();
         int GetEntityIdByName(string entityName);
         IEnumerable<Item> GetFilteredAndOrderedItems(string entity, string orderBy, bool descending, uint page, uint pageCount, out int totalCount, int userId = 0, EntityListCategory listCategory = EntityListCategory.All);
         int GetTotalItemsCount(string entity);
         IEntity GetItem(string entityName, int id, bool loadRelatedData = false);
         List<dynamic> GetItems();
         void PostItem(string id, dynamic item);
         bool DeleteItem(string entityName, int id);
         bool DeleteItems(string entityName, int[] ids);
         object GetUserData();
         IEnumerable<int> GetInverseIdsForEntity(string entity, int userId, string category, IEnumerable<int> inverseIds, int limit = 100);

    }

}
