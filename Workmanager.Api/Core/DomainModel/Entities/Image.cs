using Workmanager.Api.Core.DomainModel.NullEntities;

namespace Workmanager.Api.Core.DomainModel.Entities;

public class Image: ABaseEntity {

    #region fields
    protected Guid _id = Guid.Empty;
    #endregion    
    
    #region properties
    public override Guid Id {
        get => _id;
        set {
            _id = value == Guid.Empty ? Guid.NewGuid() : value;
        }
    }
    public string RemoteUriPath { get; set; } = string.Empty;
    public string ContentType { get; set; } = string.Empty;
    public DateTime Updated { get; set; } = DateTime.UtcNow;
    
    // Navigation Property
    // public User  User   { get; set; } = NullOwner.Instance;
    public Guid   UserId { get; set; } = Guid.Empty;
    #endregion

}