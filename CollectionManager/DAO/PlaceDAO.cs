using CollectionManager.Models;
namespace CollectionManager.DAO
{
    interface PlaceDAO
    {
        void InsertPlace(Place place);
        Place[] GetAllPlaces();
        void UpdatePlace(Place place);
        void DeletePlace(Place place);
    }
}
