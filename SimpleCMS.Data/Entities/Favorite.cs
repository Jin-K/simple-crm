using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCMS.Data.Entities {

	[Table( "Favorites" )]
	public class Favorite {

		[Required]
		public int UserId { get; set; }

		[Required]
		public int EntityId { get; set; }

		[Required]
		public int ItemId { get; set; }

		[Required]
		public System.DateTime Created { get; set; } = System.DateTime.Now;

		[ForeignKey( "UserId" )]
		[InverseProperty( "Favorites" )]
		public AppUser User { get; set; }

		[NotMapped]
		public Entity Entity { get; set; } = default( Entity );

		[NotMapped]
		public IEntity Item { get; set; } = default( IEntity );

		public Favorite(int userId, int entityId, int itemId) {
			UserId = userId;
			EntityId = entityId;
			ItemId = itemId;
		}

	}

}
